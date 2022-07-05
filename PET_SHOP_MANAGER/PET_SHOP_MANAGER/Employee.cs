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
        public int role=2;
        public int idacc=8;
        public int IdSelect=3 ;
        public void Form_Load()
        {
            dataGridView1.Rows.Clear();
            
                using (var context = new PET_SHOP_MANAGERContext())
                {

                    List<InforAccount> listInfo = context.InforAccounts.ToList();
                    
                    if(role == 1)
                    {
                    foreach (InforAccount emp in listInfo)
                    {
                        dataGridView1.Rows.Add(emp.Id,emp.Fullname, emp.Phone, emp.Email, emp.Sex, emp.Address, emp.DateofBirth, emp.Status);

                    }
                    }
                    if(role == 2)
                    {
                    List<InforAccount> info = context.InforAccounts.Where(x => x.Idacc == idacc).ToList();
                    foreach(InforAccount emp in info)
                    {
                        textBox1.Text = emp.Fullname;
                        textBox2.Text = emp.Phone;
                        textBox3.Text = emp.Address;
                        textBox4.Text = emp.Email;
                        dateTimePicker1.Value = DateTime.Parse(emp.DateofBirth.ToString());
                        if (emp.Sex == true)
                        {
                            radioButton1.Checked = true;
                        }
                        if (emp.Sex == false)
                        {
                            radioButton2.Checked = true;
                        }
                    }
                    vbButton7.Visible = false; ;
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
            
            Account a = new Account();
            
            a.Username = phone;
            a.Password = "1234";
            a.Role = 2;
            a.Status = true;
            using(var context = new PET_SHOP_MANAGERContext())
            {
                context.Accounts.Add(a);
                context.SaveChanges();
                
            }
            using(var context = new PET_SHOP_MANAGERContext())
            {
                List<Account> list = context.Accounts.Where(x => x.Username == a.Username && x.Password == a.Password).ToList();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int select = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[select];
                string cellvalue = Convert.ToString(selectRow.Cells["Id"].Value);
                using (var context = new PET_SHOP_MANAGERContext())
                    {
                        IdSelect = int.Parse(cellvalue);
                        List<InforAccount> list = context.InforAccounts.Where(x => x.Id == IdSelect).ToList();
                         textBox1.Text;
                         textBox2.Text;
                         textBox3.Text;
                         textBox4.Text;
                         dateTimePicker1.Value;
                        bool sex;
                        if (radioButton1.Checked)
                        {
                            sex = true;
                        }
                        else
                        {
                            sex = false;
                        }

                    }

                }
            }

        private void vbButton9_Click(object sender, EventArgs e)
        {

        }

        private void vbButton8_Click(object sender, EventArgs e)
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
                sex = false;
            }
            
            using(var context = new PET_SHOP_MANAGERContext())
            {
                List<InforAccount> list = context.InforAccounts.Where(x => x.Id == IdSelect).ToList();
                InforAccount info = new InforAccount();
                foreach (var account in list)
                {
                    info = account;
                }
                info.Fullname = name;
                info.Phone = phone;
                info.Address = address; 
                info.Email = email;
                info.DateofBirth = birth;
                info.Sex = sex;
                context.InforAccounts.Update(info);
                context.SaveChanges();
                Form_Load();
            }

        }
    }
}
