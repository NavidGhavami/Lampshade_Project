using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Domain;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contract.Comment;
using ShopManagement.Domain.Comment;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class CommentRepository : RepositoryBase<long, Comment>,ICommentRepository
    {
        private readonly ShopContext _shopContext;
        public CommentRepository(ShopContext shopContext) : base(shopContext)
        {
            _shopContext = shopContext;
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
            var query = _shopContext.Comments
                .Include(x=>x.Product)
                .Select(x => new CommentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Message = x.Message,
                ProductId = x.ProductId,
                IsCanceled = x.IsCanceled,
                IsConfirmed = x.IsConfirmed,
                ProductName = x.Product.Name,
                CreationDate = x.CreationDate.ToFarsi()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
            {
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.Email))
            {
                query = query.Where(x => x.Email.Contains(searchModel.Email));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
