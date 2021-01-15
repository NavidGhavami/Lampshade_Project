using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using AccountManagement.Application.Contract.Role;
using Microsoft.AspNetCore.Http;

namespace AccountManagement.Application.Contract.Account
{
    public class CreateAccount
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string FullName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Username { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = ValidationMessages.IsRequired)]
        public long RoleId { get; set; }
        public List<RoleViewModel> Roles { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Mobile { get; set; }

        [FileExtensionLimitation(new string[] { "jpeg", "jpg", "png" }, ErrorMessage = ValidationMessages.InvalidFileFormat)]
        [MaxFileSize(3 * 1024 * 1024, ErrorMessage = ValidationMessages.MaxFileSize)]
        public IFormFile ProfilePhoto { get; set; }

    }
}
