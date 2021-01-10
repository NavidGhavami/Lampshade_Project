using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contract.Comment;

namespace ShopManagement.Domain.Comment
{
    public interface ICommentRepository:IRepository<long , Comment>
    {
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
