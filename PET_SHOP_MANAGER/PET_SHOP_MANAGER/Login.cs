using System;
using PET_SHOP_MANAGER.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PET_SHOP_MANAGER
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            using(var context = new PET_SHOP_MANAGERContext())
            {
                List<Account> list =context.Accounts.Where(x => x.Username == username && x.Password == password).ToList();
                if(list.Count == 0)
                {
                    MessageBox.Show("Ten Dang Nhap Hoac Mat Khau Khong Dung !!!");
                }
                else
                {
                    int id = list[0].Id;
                    Home form = new Home(id);
                    form.Show();
                }
                
            }
           
        }
    }
}
