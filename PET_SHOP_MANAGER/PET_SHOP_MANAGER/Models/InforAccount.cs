using System;
using System.Collections.Generic;

#nullable disable

namespace PET_SHOP_MANAGER.Models
{
    public partial class InforAccount
    {
        internal static object context;

        public InforAccount()
        {
            Orders = new HashSet<Order>();
        }

        public InforAccount(int id, string fullname, string phone, string email, bool? sex, string address, DateTime? dateofBirth)
        {
            Id = id;
            Fullname = fullname;
            Phone = phone;
            Email = email;
            Sex = sex;
            Address = address;
            DateofBirth = dateofBirth;
        }

        public int Id { get; set; }
        public int? Idacc { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? Sex { get; set; }
        public string Address { get; set; }
        public DateTime? DateofBirth { get; set; }
        public bool? Status { get; set; }

        public virtual Account IdaccNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
