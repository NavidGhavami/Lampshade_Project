﻿namespace ShopManagement.Application.Contract.Comment
{
    public class CommentViewModel
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string ProductName { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsCanceled { get; set; }
        public string CreationDate { get; set; }

    }
}