using System.Collections.Generic;
using _0_Framework.Application;
using AccountManagement.Application.Contract.Account;
using AccountManagement.Domain.AccountAgg;

namespace AccountManagement.Application
{
    public class AccountApplication : IAccountApplication
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly IAccountRepository _accountRepository;
        private readonly IFileUploader _fileUploader;

        public AccountApplication(IAccountRepository accountRepository, IPasswordHasher passwordHasher, IFileUploader fileUploader)
        {
            _accountRepository = accountRepository;
            _passwordHasher = passwordHasher;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateAccount command)
        {
            var operation = new OperationResult();

            if (_accountRepository.Exist(x => x.Username == command.Username || x.Mobile == command.Mobile))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }
            var picturePath = $"ProfilePhotos";
            var photoName = _fileUploader.Upload(command.ProfilePhoto, picturePath);

            var password = _passwordHasher.Hash(command.Password);

            var account = new Account(command.FullName, command.Username, password, command.RoleId, command.Mobile, photoName);

            _accountRepository.Create(account);
            _accountRepository.SaveChanges();

            return operation.Succedded();

        }

        public OperationResult Edit(EditAccount command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.Get(command.Id);
            if (account == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }
            if (_accountRepository.Exist(x => x.Username == command.Username || x.Mobile == command.Mobile && x.Id != command.Id))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }

            var picturePath = $"ProfilePhotos";
            var photoName = _fileUploader.Upload(command.ProfilePhoto, picturePath);

            account.Edit(command.FullName, command.Username, command.RoleId, command.Mobile, photoName);

            _accountRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult ChangePassword(ChangePassword command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.Get(command.Id);
            if (account == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }
            if (command.Password != command.RePassword)
            {
                return operation.Failed(ApplicationMessages.DuplicatedPassword);
            }

            var password = _passwordHasher.Hash(command.Password);
            account.ChangePassword(password);

            _accountRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditAccount GetDetails(long id)
        {
            return _accountRepository.GetDetails(id);
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            return _accountRepository.Search(searchModel);
        }
    }
}
