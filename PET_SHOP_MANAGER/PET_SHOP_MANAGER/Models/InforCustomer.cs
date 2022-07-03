using System;
using System.Collections.Generic;

#nullable disable

namespace PET_SHOP_MANAGER.Models
{
    public partial class InforCustomer
    {
        public InforCustomer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Sex { get; set; }
        public string Phone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
