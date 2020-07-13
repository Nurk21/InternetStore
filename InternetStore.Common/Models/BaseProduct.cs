using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InternetStore.Common.Models
{
    public interface IBaseProduct
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public List<string> ProductReviews { get; set; }
        public List<ProductPrice> ProductPrices { get; set; }
        public int ProductQuantityAvailable { get; set; }
    }
    public class BaseProduct : IIdentifiable, IBaseProduct
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public List<string> ProductReviews { get; set; }
        public List<ProductPrice> ProductPrices { get; set; }
        [Required]
        public int ProductQuantityAvailable { get; set; }
    }
}
