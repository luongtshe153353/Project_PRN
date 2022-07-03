using System;
using System.Collections.Generic;

#nullable disable

namespace PET_SHOP_MANAGER.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int? Idorder { get; set; }
        public int? Product { get; set; }
        public int? Quantity { get; set; }

        public virtual Order IdorderNavigation { get; set; }
        public virtual Product ProductNavigation { get; set; }
    }
}
