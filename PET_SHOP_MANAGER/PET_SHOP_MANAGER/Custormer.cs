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
    public partial class Custormer : Form
    {
        int id;
        int role;
        int idselect;
        public Custormer(int id,int role)
        {
            this.id = id;
            this.role = role;
            InitializeComponent();
        }

        public void Form_Load(string name,string phone)
        {
            dataGridView1.Rows.Clear();

            using (var context = new PET_SHOP_MANAGERContext())
            {

                List<InforCustomer> listInfo = context.InforCustomers.Where(x => x.Name.Contains(name) && x.Phone.Contains(phone)).ToList();
                
                
                    foreach (InforCustomer emp in listInfo)
                    {
                    string sex="";
                    if(emp.Sex == true)
                    {
                        sex = "Male";
                    }else if(emp.Sex == false)
                    {
                        sex = "Female";
                    }
                        dataGridView1.Rows.Add(emp.Id, emp.Name, emp.Phone, emp.Email, sex, emp.Address, emp.DateOfBirth, emp.Status);

                    }
     

            }
        }
        private void Custormer_Load(object sender, EventArgs e)
        {
            Form_Load("","");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            string phone = textBox6.Text;
            Form_Load(name, phone);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            string phone = textBox6.Text;
            Form_Load(name, phone);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int select = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[select];
                string cellvalue = Convert.ToString(selectRow.Cells["Column8"].Value);
                using (var context = new PET_SHOP_MANAGERContext())
                {
                    idselect = int.Parse(cellvalue);
                    InforCustomer infor = context.InforCustomers.Where(x => x.Id == idselect).SingleOrDefault();
                        textBox1.Text = infor.Name;
                        textBox2.Text = infor.Phone;
                        textBox3.Text = infor.Address;
                        textBox4.Text = infor.Email;
                        dateTimePicker1.Value = DateTime.Parse(infor.DateOfBirth.ToString());
                        bool sex = bool.Parse(infor.Sex.ToString());
                        if (sex == true)
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                    }
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

            using (var context = new PET_SHOP_MANAGERContext())
            {
                InforCustomer info = context.InforCustomers.Where(x => x.Id == idselect).SingleOrDefault();
                info.Name = name;
                info.Phone = phone;
                info.Address = address;
                info.Email = email;
                info.DateOfBirth = birth;
                info.Sex = sex;
                context.InforCustomers.Update(info);
                context.SaveChanges();
                Form_Load("","");
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

            Home form = new Home(id, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frmProduct form = new frmProduct(id, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            Employee form = new Employee(id, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Custormer form = new Custormer(id, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {
            Bill form = new Bill(id, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton7_Click(object sender, EventArgs e)
        {
            Cart form = new Cart(id, role);
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
    }

}