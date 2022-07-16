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
    public partial class Cart : Form
    {
        int id;
        int role;
        int type_id = 1;
        int idselect;
        List<Product> ListProduct = new List<Product>();
        public Cart(int id,int role)
        {
            this.id = id;
            this.role = role;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Form_Load(int type,string name)
        {
            dataGridView1.Rows.Clear();
            using (var context = new PET_SHOP_MANAGERContext())
            {
                comboBox2.ValueMember = "Id";
                comboBox2.SelectedValue = type;
                List<Product> products = context.Products.Where(x => x.Type == type && x.Name.Contains(name)).ToList();
                foreach (var item in products)
                {
                    string sex = "";
                    if (item.Sex == true)
                    {
                        sex = "Male";
                    }
                    else if (item.Sex == false)
                    {
                        sex = "Female";
                    }
                    dataGridView1.Rows.Add(item.Id, item.Name, sex, item.Quantity,item.Price);
                }

            }
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            using (var context = new PET_SHOP_MANAGERContext())
            {
                List<TypeProduct> typeProducts = context.TypeProducts.ToList();
                comboBox2.DataSource = typeProducts;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
            }
            Form_Load(type_id, "");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            type_id = int.Parse(comboBox2.SelectedValue.ToString());
            Form_Load(type_id, name);
        }
       

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            type_id = int.Parse(comboBox2.SelectedValue.ToString());
            Form_Load(type_id, name);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int select = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[select];
                string cellvalue = Convert.ToString(selectRow.Cells["Column1"].Value);
                using (var context = new PET_SHOP_MANAGERContext())
                {
                    idselect = int.Parse(cellvalue);
                    List<Product> list = context.Products.Where(x => x.Id == idselect).ToList();
                    foreach (var p in list)
                    {
                        textBox9.Text = p.Name;
                        textBox6.Text = p.Price.ToString();
                        numericUpDown1.Value = 1;
                    }
                }

            }
        }
        public void Form2_Load()
        {
            dataGridView2.Rows.Clear();
            int tt = 0;
            for (int i = 0; i < ListProduct.Count; i++)
            {
                int qty = 1;
                int count = 0;
                for (int j = 0; j < ListProduct.Count; j++)
                {
                    if (ListProduct[i].Id == ListProduct[j].Id && i < j)
                    {
                        qty++;
                    }
                    else if (ListProduct[i].Id == ListProduct[j].Id && i > j)
                    {
                        count++;
                    }
                }
                int total = (int)(qty * ListProduct[i].Price);
                tt = tt + total;
                if (qty > 0 && count == 0)
                {
                    
                    dataGridView2.Rows.Add(ListProduct[i].Id, ListProduct[i].Name, qty, ListProduct[i].Price, total);
                }

            }
            label10.Text = tt.ToString();
        }
        private void vbButton7_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            using (var context = new PET_SHOP_MANAGERContext())
            {
                Product product = context.Products.Where(x => x.Id == idselect).SingleOrDefault();
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    ListProduct.Add(product);
                }
                Form2_Load();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int select = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[select];
                string cellvalue = Convert.ToString(selectRow.Cells["Column1"].Value);
                using (var context = new PET_SHOP_MANAGERContext())
                {
                    idselect = int.Parse(cellvalue);
                    Product p = ListProduct.Where(x => x.Id == select).SingleOrDefault();
                    ListProduct.Remove(p);
                    Form2_Load();
                }
                
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string phone = textBox2.Text;   
            string email = textBox4.Text;
            string address = textBox3.Text;
            DateTime date = dateTimePicker1.Value;
            bool sex=true;
            if(radioButton1.Checked == true)
            {
                sex = true;
            }
            if(radioButton2.Checked == true)
            {
                sex = false;
            }
            if (name == "" || phone == "")
            {
                MessageBox.Show("Chua nhap ten hoac sdt");
            }
            else if (ListProduct.Count == 0)
            {
                MessageBox.Show("Chua co san pham");
            }
            else
            {
                using (var context = new PET_SHOP_MANAGERContext())
            {
                InforCustomer infor = new InforCustomer();
                infor.Address = address;
                infor.Phone = phone;
                infor.Email = email;
                infor.Name = name;
                infor.Sex = sex;
                infor.DateOfBirth = date;
                
                    context.InforCustomers.Add(infor);
                    context.SaveChanges();
                    InforCustomer inforCustomer = context.InforCustomers.Where(x => x.Name == name && x.Phone == phone && x.Address == address).SingleOrDefault();
                    DateTime d = DateTime.Now;
                    int total = int.Parse(label10.Text);
                    Order o = new Order();
                    o.InforCustomer = inforCustomer.Id;
                    o.InforEmployee = id;
                    o.Date = d;
                    o.Total = total;
                    context.Orders.Add(o);
                    context.SaveChanges();
                    Order order = context.Orders.Where(x => x.InforCustomer == inforCustomer.Id && x.InforEmployee == id && x.Date == d).SingleOrDefault();
                    for (int i = 0; i < ListProduct.Count; i++)
                    {
                        int qty = 1;
                        int count = 0;
                        for (int j = 0; j < ListProduct.Count; j++)
                        {
                            if (ListProduct[i].Id == ListProduct[j].Id && i < j)
                            {
                                qty++;
                            }
                            else if (ListProduct[i].Id == ListProduct[j].Id && i > j)
                            {
                                count++;
                            }
                        }
                        if (qty > 0 && count == 0)
                        {
                            OrderDetail od = new OrderDetail();
                            od.Idorder = order.Id;
                            od.Product = ListProduct[i].Id;
                            od.Quantity = qty;
                            context.OrderDetails.Add(od);
                            context.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}
