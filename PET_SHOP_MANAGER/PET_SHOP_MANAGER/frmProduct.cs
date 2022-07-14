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
    public partial class frmProduct : Form
    {
        int id;
        int role;
        int type_id=1;
        int idselect;
        public frmProduct(int id,int role)
        {
            this.id = id;
            this.role = role;
            InitializeComponent();
        }
        public void Form_Load(int type,string name)
        {
            dataGridView1.Rows.Clear();
            using(var context = new PET_SHOP_MANAGERContext())
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
                    else if(item.Sex == false)
                    {
                        sex = "Female";
                    }
                    dataGridView1.Rows.Add(item.Id, item.Name, sex, item.Dateofbirth, item.Price, item.Quantity, item.Status);
                }
                
            }
        }
        private void Product_Load(object sender, EventArgs e)
        {
            using (var context = new PET_SHOP_MANAGERContext())
            {
                List<TypeProduct> typeProducts = context.TypeProducts.ToList();
                List<TypeProduct> typeProducts2 = context.TypeProducts.ToList();
                comboBox1.DataSource = typeProducts;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
                comboBox2.DataSource = typeProducts2;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
            }
            Form_Load(type_id,"");
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

                        textBox1.Text = p.Name;
                        numericUpDown1.Value = (int)p.Quantity;
                        numericUpDown2.Value = (int)p.Price;
                        comboBox1.SelectedValue = p.Type;
                        dateTimePicker1.Value = (DateTime)p.Dateofbirth;
                        string sex = p.Sex.ToString();
                        if (sex != "")
                        {
                            bool s = bool.Parse(sex);
                            if (s == true)
                            {
                                radioButton1.Checked = true;
                            }
                            else if (s == false)
                            {
                                radioButton2.Checked = true;
                            }
                        }
                        
                    }
                }

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                string name = textBox2.Text;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
                type_id = int.Parse(comboBox2.SelectedValue.ToString());
                Form_Load(type_id,name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            type_id = int.Parse(comboBox2.SelectedValue.ToString());
            Form_Load(type_id, name);
        }

        private void vbButton7_Click(object sender, EventArgs e)
        {
            
            using(var context = new PET_SHOP_MANAGERContext())
            {
                comboBox2.ValueMember = "Id";
                string name = textBox1.Text;
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int price = int.Parse(numericUpDown2.Value.ToString());
                int type = int.Parse(comboBox1.SelectedValue.ToString());
                DateTime date = dateTimePicker1.Value;
                List<Product> list = context.Products.ToList();
                Product product = new Product();
                product.Name = name;
                product.Quantity = quantity;
                product.Price = price;
                product.Type = type;
                product.Dateofbirth = date;
                if (radioButton1.Checked)
                {
                     product.Sex = true;
                }
                else if (radioButton2.Checked)
                {
                    product.Sex = false;
                }
                product.Status = true;
                context.Products.Add(product);
                context.SaveChanges();
                Form_Load(type, "");
                MessageBox.Show("Add Product Successfull");
            }
        }

        private void vbButton9_Click(object sender, EventArgs e)
        {
            AddProductType form = new AddProductType(id,role);
            form.Show();
        }

        private void vbButton8_Click(object sender, EventArgs e)
        {
            using (var context = new PET_SHOP_MANAGERContext())
            {

                string name = textBox1.Text;
                int quantity = int.Parse(numericUpDown1.Value.ToString());
                int price = int.Parse(numericUpDown2.Value.ToString());
                int type = int.Parse(comboBox1.SelectedValue.ToString());
                DateTime date = dateTimePicker1.Value;
                List<Product> list = context.Products.ToList();
                Product product = new Product();
                product.Id = idselect;
                product.Name = name;
                product.Quantity = quantity;
                product.Price = price;
                product.Type = type;
                product.Dateofbirth = date;
                if (radioButton1.Checked)
                {
                    product.Sex = true;
                }
                else if (radioButton2.Checked)
                {
                    product.Sex = false;
                }
                product.Status = true;
                context.Products.Update(product);
                context.SaveChanges();
                Form_Load(type, name);
            }
        }
    }
}

