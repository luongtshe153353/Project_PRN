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
    public partial class Bill : Form
    {
        int id;
        int role;
        public Bill(int id,int role)
        {
            this.id = id;
            this.role = role;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void Form_Load(string name, string phone, string employee)
        {
            dataGridView1.Rows.Clear();
            using (var context = new PET_SHOP_MANAGERContext())
            {
                List<Order> orders = context.Orders.ToList();
                List<InforCustomer> inforCustomers = context.InforCustomers.ToList();
                List<InforAccount> inforAccounts = context.InforAccounts.ToList();
                var query = (from o in orders
                             join ic in inforCustomers on o.InforCustomer equals ic.Id
                             join ia in inforAccounts on o.InforEmployee equals ia.Id
                             where ic.Name.Contains(name) && ic.Phone.Contains(phone) && ia.Fullname.Contains(employee)
                             select new
                             {
                                 o.Id,
                                 ic.Name,
                                 ia.Phone,
                                 o.Total,
                                 o.Date,
                                 ia.Fullname,
                             }).OrderBy(x => x.Date);
                foreach (var item in query)
                {
                    dataGridView1.Rows.Add(item.Id, item.Name, item.Phone, item.Total, item.Date, item.Fullname);
                }
            }
        }
        private void Bill_Load(object sender, EventArgs e)
        {
            Form_Load("", "", "");
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string phone = textBox3.Text;
            string employee = textBox1.Text;
            Form_Load(name, phone, employee);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string phone = textBox3.Text;
            string employee = textBox1.Text;
            Form_Load(name, phone, employee);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string phone = textBox3.Text;
            string employee = textBox1.Text;
            Form_Load(name, phone, employee);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Clear();
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int select = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[select];
                string cellvalue = Convert.ToString(selectRow.Cells["Column1"].Value);
                using (var context = new PET_SHOP_MANAGERContext())
                {
                    int id = int.Parse(cellvalue);
                    List<OrderDetail> list = context.OrderDetails.ToList();
                    List<Product> listP = context.Products.ToList();
                    var query = (from od in list
                                 join p in listP on od.Product equals p.Id
                                 where od.Idorder == id
                                 select new
                                 {
                                     p.Name,
                                     p.Sex,
                                     p.Dateofbirth,
                                     od.Quantity,
                                     p.Price,
                                     V = (od.Quantity * p.Price).ToString()
                                 }).OrderBy(x => x.Name);
                    foreach(var item in query)
                    {
                        dataGridView2.Rows.Add(item.Name,item.Sex,item.Dateofbirth,item.Quantity,item.Price,item.V);
                    }
                }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
