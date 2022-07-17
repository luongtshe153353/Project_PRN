﻿using PET_SHOP_MANAGER.Models;
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
        public int role;
        public int idacc;
        public int IdSelect;
        public Employee(int id,int role)
        {
            this.idacc = id;    
            this.role = role;
            InitializeComponent();
        }
        
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
            int idacc;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int select = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[select];
                string cellvalue = Convert.ToString(selectRow.Cells["Column8"].Value);
                using (var context = new PET_SHOP_MANAGERContext())
                    {
                        IdSelect = int.Parse(cellvalue);
                        List<InforAccount> list = context.InforAccounts.Where(x => x.Id == IdSelect).ToList();
                    foreach (var account in list)
                    {

                        idacc = int.Parse(account.Idacc.ToString());
                        textBox1.Text = account.Fullname;
                        textBox2.Text = account.Phone;
                        textBox3.Text= account.Address;
                        textBox4.Text = account.Email;
                        dateTimePicker1.Value = DateTime.Parse(account.DateofBirth.ToString());
                        bool sex = bool.Parse(account.Sex.ToString());
                        if (sex==true)
                        {
                            radioButton1.Checked=true;
                        }
                        else
                        {
                            radioButton2.Checked=true;
                        }
                    }
                    }

                }
            }

        private void vbButton9_Click(object sender, EventArgs e)
        {
            if(role == 1)
            {
               ChangePassword form = new ChangePassword(IdSelect,1);
               form.Show();
            }
            if(role == 2)
            {
                ChangePassword form = new ChangePassword(idacc, 2);
                form.Show();
            }
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (role == 1)
            {
            
            string name = textBox5.Text;
            string phone = textBox6.Text;
            using (var context = new PET_SHOP_MANAGERContext())
            {
                List<InforAccount> list = context.InforAccounts.Where(x => x.Fullname.Contains(name) && x.Phone.Contains(phone)).ToList();
                foreach (InforAccount emp in list)
                {
                       
                    dataGridView1.Rows.Add(emp.Id, emp.Fullname, emp.Phone, emp.Email, emp.Sex, emp.Address, emp.DateofBirth, emp.Status);

                }
            }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (role == 1)
            {

                string name = textBox5.Text;
                string phone = textBox6.Text;
                using (var context = new PET_SHOP_MANAGERContext())
                {
                    List<InforAccount> list = context.InforAccounts.Where(x => x.Fullname.Contains(name) && x.Phone.Contains(phone)).ToList();
                    foreach (InforAccount emp in list)
                    {

                        dataGridView1.Rows.Add(emp.Id, emp.Fullname, emp.Phone, emp.Email, emp.Sex, emp.Address, emp.DateofBirth, emp.Status);

                    }
                }
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            Home form = new Home(idacc, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            Employee form = new Employee(idacc, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Custormer form = new Custormer(idacc, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton10_Click(object sender, EventArgs e)
        {
            Cart form = new Cart(idacc, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {
            Bill form = new Bill(idacc, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton6_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frmProduct form = new frmProduct(idacc, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }
    }
}
