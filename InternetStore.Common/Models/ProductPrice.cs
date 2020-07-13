using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.Common.Models
{
    public class ProductPrice : IIdentifiable
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
