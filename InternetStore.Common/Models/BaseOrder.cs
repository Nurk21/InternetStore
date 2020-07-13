using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InternetStore.Common.Models
{
    public interface IBaseOrder
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductPrice> ProductPrices { get; set; }
    }
    public class BaseOrder : IBaseOrder, IIdentifiable
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }
        [Required]
        public List<Product> Products { get; set; }
        [Required]
        public List<ProductPrice> ProductPrices { get; set; }
    }
}
