using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PET_SHOP_MANAGER.Models;

namespace PET_SHOP_MANAGER
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        public int id;

        public ChangePassword(int id)
        {
            this.id = id;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            using(var context = new PET_SHOP_MANAGERContext())
            {
                List<Account> list = context.Accounts.Where(x => x.Id == id).ToList();
                foreach(var account in list)
                {
                    label1.Text = account.Username;   
                }
            }
            
        }
    }
}
