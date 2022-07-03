using System;
using System.Collections.Generic;

#nullable disable

namespace PET_SHOP_MANAGER.Models
{
    public partial class Account
    {
        public Account()
        {
            InforAccounts = new HashSet<InforAccount>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<InforAccount> InforAccounts { get; set; }
    }
}
