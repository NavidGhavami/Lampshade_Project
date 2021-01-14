using System.Collections.Generic;
using System.Runtime.InteropServices;
using _0_Framework.Domain;
using CommentManagement.Application.Contract.Comment;


namespace CommentManagement.Domain.Comment
{
    public interface ICommentRepository:IRepository<long , Comment>
    {
        List<CommentViewModel> Search(CommentSearchModel searchModel);
        List<CommentViewModel> GetAllProductComments(int type);
        List<CommentViewModel> GetAllArticleComments(int type);
    }
}
