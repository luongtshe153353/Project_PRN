using System;
using System.Collections.Generic;

#nullable disable

namespace PET_SHOP_MANAGER.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? InforEmployee { get; set; }
        public int? InforCustomer { get; set; }
        public int? Total { get; set; }

        public virtual InforCustomer InforCustomerNavigation { get; set; }
        public virtual InforAccount InforEmployeeNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
