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
        private int id;
        private int role;
        public ChangePassword(int id, int role)
        {
            this.id = id;
            this.role = role;
            InitializeComponent();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            using(var context = new PET_SHOP_MANAGERContext())
            {
                List<Account> list = context.Accounts.Where(x => x.Id == id).ToList();
                foreach(var account in list)
                {
                    label5.Text = account.Username;   
                }
                if (role == 1)
                {
                    label3.Visible = false;
                    textBox4.Visible = false;
                }
            }
            
        }

        private void vbButton9_Click(object sender, EventArgs e)
        {
            string oldpass = textBox4.Text;
            string newpass = textBox1.Text;
            string cfpass = textBox2.Text;
            using(var context = new PET_SHOP_MANAGERContext())
            {
                List<Account> accounts = context.Accounts.Where(x => x.Id == id).ToList();
                foreach (var account in accounts)
                {
                    if (role == 1)
                    {
                        if (newpass.Equals(cfpass))
                        {
                            account.Password = cfpass;
                            context.Accounts.Update(account);
                            context.SaveChanges();
                            MessageBox.Show("Thay Doi Mat Khau Thanh Cong!!");
                        }
                        else
                        {
                            MessageBox.Show("Mat Khau moi va mat khau xac nhanj khong giong nhau!!");
                        }
                    }
                    else
                    {
                        if (account.Password.Equals(oldpass))
                        {
                            if (newpass.Equals(cfpass))
                            {
                                account.Password = cfpass;
                                context.Accounts.Update(account);
                                context.SaveChanges();
                                MessageBox.Show("Thay Doi Mat Khau Thanh Cong!!");
                            }
                            else
                            {
                                MessageBox.Show("Mat Khau moi va mat khau xac nhanj khong giong nhau!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mat Khau cu khong dung vui long nhap lai!!");
                        }
                    }
                    
                }
            }
        }
    }
}
