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
    public partial class Home : Form
    {
        public int id;
        private int role;
        public Home(int id,int role)
        {
            this.id = id;
            this.role = role;
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Form_Load(string type,string time)
        {
            
            DateTime d = DateTime.Parse(dateTimePicker1.Value.ToString());
            using(var context = new PET_SHOP_MANAGERContext())
            {
                double dog=0;
                double cat=0;
                double Orther=0;
                double Total=0;
                List<OrderDetail> orderDetails = context.OrderDetails.ToList();
                List<Order> orders = context.Orders.ToList();
                List<Product> products = context.Products.ToList();
                 
                if (type.Equals("Year"))
                {
                    var query = (from o in orders
                                 join od in orderDetails on o.Id equals od.Idorder
                                 join pr in products on od.Product equals pr.Id
                                 where DateTime.Parse(o.Date.ToString()).Year == d.Year
                                 select new
                                 {
                                     o.Date,
                                     o.Total,
                                     pr.Type
                                 });
                    foreach(var item in query)
                    {
                        if(item.Type == 1)
                        {
                            dog = double.Parse(item.Total.ToString())+dog;
                        }
                        if(item.Type == 2)
                        {
                            cat = double.Parse(item.Total.ToString()) + cat;
                        }
                        if(item.Type !=1 && item.Type != 2)
                        {
                            Orther = double.Parse(item.Total.ToString()) + Orther;
                        }
                        Total = dog + cat + Orther;
                        label5.Text = dog + "$";
                        label6.Text = cat +"$";
                        label7.Text = Orther + "$";
                        label8.Text = Total + "$";
                    }
                }
                else if (type.Equals("Month"))
                {
                    var query = (from o in orders
                                 join od in orderDetails on o.Id equals od.Idorder
                                 join pr in products on od.Product equals pr.Id
                                 where DateTime.Parse(o.Date.ToString()).Year == d.Year 
                                 && DateTime.Parse(o.Date.ToString()).Month == d.Month
                                 select new
                                 {
                                     o.Date,
                                     o.Total,
                                     pr.Type
                                 });
                    foreach (var item in query)
                    {
                        if (item.Type == 1)
                        {
                            dog = double.Parse(item.Total.ToString()) + dog;
                        }
                        if (item.Type == 2)
                        {
                            cat = double.Parse(item.Total.ToString()) + cat;
                        }
                        if (item.Type != 1 && item.Type != 2)
                        {
                            Orther = double.Parse(item.Total.ToString()) + Orther;
                        }
                        Total = dog + cat + Orther ;
                        label5.Text = dog + "$";
                        label6.Text = cat + "$";
                        label7.Text = Orther + "$";
                        label8.Text = Total + "$";
                    }
                }
               else if (type.Equals("Month"))
                {
                    var query = (from o in orders
                                 join od in orderDetails on o.Id equals od.Idorder
                                 join pr in products on od.Product equals pr.Id
                                 where DateTime.Parse(o.Date.ToString()).Year == d.Year
                                 && DateTime.Parse(o.Date.ToString()).Month == d.Month
                                 && DateTime.Parse(o.Date.ToString()).Day == d.Day
                                 select new
                                 {
                                     o.Date,
                                     o.Total,
                                     pr.Type
                                 });
                    foreach (var item in query)
                    {
                        if (item.Type == 1)
                        {
                            dog = double.Parse(item.Total.ToString()) + dog;
                        }
                        if (item.Type == 2)
                        {
                            cat = double.Parse(item.Total.ToString()) + cat;
                        }
                        if (item.Type != 1 && item.Type != 2)
                        {
                            Orther = double.Parse(item.Total.ToString()) + Orther;
                        }
                        Total = dog + cat + Orther;
                        label5.Text = dog + "$";
                        label6.Text = cat + "$";
                        label7.Text = Orther + "$";
                        label8.Text = Total + "$";
                    }
                }
                else if (type.Equals("Total")){
                    var query = (from o in orders
                                 join od in orderDetails on o.Id equals od.Idorder
                                 join pr in products on od.Product equals pr.Id
                                 select new
                                 {
                                     o.Date,
                                     o.Total,
                                     pr.Type
                                 });
                    foreach (var item in query)
                    {
                        if (item.Type == 1)
                        {
                            dog = double.Parse(item.Total.ToString()) + dog;
                        }
                        if (item.Type == 2)
                        {
                            cat = double.Parse(item.Total.ToString()) + cat;
                        }
                        if (item.Type != 1 && item.Type != 2)
                        {
                            Orther = double.Parse(item.Total.ToString()) + Orther;
                        }
                        Total = dog + cat + Orther;
                        label5.Text = dog + "$";
                        label6.Text = cat + "$";
                        label7.Text = Orther + "$";
                        label8.Text = Total + "$";
                    }
                }
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            List<String> list = new List<String>();
            list.Add("Total");
            list.Add("Year");
            list.Add("Month");
            list.Add("Day");
            for(int i =0;i< list.Count; i++)
            {
                comboBox1.Items.Add(list[i]);
            }
            comboBox1.SelectedItem = "Total";
            using (var context = new PET_SHOP_MANAGERContext()) {
                List<InforAccount> info = context.InforAccounts.Where(x => x.Idacc == id).ToList();
                foreach (InforAccount emp in info)
                {
                    label12.Text = emp.Fullname;
                }
            }
            DateTime d = DateTime.Now;
            Form_Load("Total", d.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            Employee form = new Employee(id,role);
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

        private void vbButton5_Click(object sender, EventArgs e)
        {
            Cart form = new Cart(id, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Bill form = new Bill(id, role);
            Program.SetMainContent(form);
            Program.ShowMainContent();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            string Type = comboBox1.SelectedItem.ToString();
            MessageBox.Show(Type);
            Form_Load(Type,d.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            string Type = comboBox1.SelectedItem.ToString();
            Form_Load(Type, d.ToString());
        }
    }
}
