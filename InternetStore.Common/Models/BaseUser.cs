using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InternetStore.Common.Models
{
    public interface IBaseUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
    public abstract class BaseUser : IIdentifiable, IBaseUser
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public Guid CartId { get; set; }
        public Cart Cart { get; set; }
    }
}
