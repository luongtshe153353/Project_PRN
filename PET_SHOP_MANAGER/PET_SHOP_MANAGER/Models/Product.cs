using System;
using System.Collections.Generic;

#nullable disable

namespace PET_SHOP_MANAGER.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Sex { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public int? Type { get; set; }
        public bool? Status { get; set; }
        public DateTime? Dateofbirth { get; set; }

        public virtual TypeProduct TypeNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
