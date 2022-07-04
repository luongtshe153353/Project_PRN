using PET_SHOP_MANAGER.Models;
using System;
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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        public void Form_Load()
        {
            dataGridView1.Rows.Clear();
            using (var context = new PET_SHOP_MANAGERContext())
            {

                List<InforAccount> listInfo = context.InforAccounts.ToList();
                List<Account> listAcc = new List<Account>();
                foreach (Account emp in listAcc)
                {
                    InforAccount account = (InforAccount)context.InforAccounts.Where(x => x.Idacc == emp.Id);
                    listInfo.Add(account);
                }
                foreach (InforAccount emp in listInfo)
                {
                    dataGridView1.Rows.Add(emp.Fullname, emp.Phone, emp.Email, emp.Sex, emp.Address, emp.DateofBirth, emp.Status);
                }
            }
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void vbButton7_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string phone = textBox2.Text;
            string address = textBox3.Text;
            string email = textBox4.Text;
            DateTime birth = dateTimePicker1.Value;
            bool sex;
            if (radioButton1.Checked)
            {
                sex = true;
            }
            else
            {
                sex=false;
            }
            string username = textBox8.Text;
            string password = textBox7.Text;
            Account a = new Account();
            a.Username = username;
            a.Password = password;
            a.Role = 2;
            a.Status = true;
            using(var context = new PET_SHOP_MANAGERContext())
            {
                context.Accounts.Add(a);
                context.SaveChanges();
                
            }
            using(var context = new PET_SHOP_MANAGERContext())
            {
                List<Account> list = context.Accounts.Where(x => x.Username == username && x.Password == password).ToList();
                InforAccount info = new InforAccount();
                Account ac = new Account();
                foreach(Account account in list)
                {
                    ac.Id = account.Id;
                }
                info.Idacc = ac.Id;
                info.Fullname =name;
                info.Email = email;
                info.Phone = phone;
                info.Address = address;
                info.DateofBirth = birth;
                info.Sex = sex;
                info.Status = true;
                context.InforAccounts.Add(info);
                context.SaveChanges();
                Form_Load();
            }
        }
    }
}
