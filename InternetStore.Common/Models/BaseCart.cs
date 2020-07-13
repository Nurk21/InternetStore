using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Text;

namespace InternetStore.Common.Models
{
    public interface IBaseCart
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
    }
    public class BaseCart : IIdentifiable, IBaseCart
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
    }
}
