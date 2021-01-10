using System.Security.Principal;
using _0_Framework;

namespace ShopManagement.Domain.Comment
{
    public class Comment : EntityBase
    {
        public long ProductId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public Product.Product Product { get; private set; }
        public bool IsConfirmed { get; private set; }
        public bool IsCanceled { get; private set; }

        public Comment(long productId, string name, string email, string message)
        {
            ProductId = productId;
            Name = name;
            Email = email;
            Message = message;
        }

        public void Confirm()
        {
            IsConfirmed = true;
        }

        public void Cancel()
        {
            IsCanceled = true;
        }
    }
}
