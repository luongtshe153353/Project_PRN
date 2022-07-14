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
    public partial class Billing : Form
    {
        int id;
        int role;
        int type_id = 1;
        int idselect;
        List<Product> ListProduct = new List<Product>();
        public Billing(int id,int role)
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
        private void Billing_Load(object sender, EventArgs e)
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
                for(int i =0; i < ListProduct.Count; i++)
                {
                    int qty = 1;
                    int count=0;
                    for (int j = 0; j < ListProduct.Count; j++)
                    {
                        if(ListProduct[i].Id == ListProduct[j].Id && i < j )
                        {
                            qty++;
                        }else if(ListProduct[i].Id == ListProduct[j].Id && i > j)
                        {
                            count++;
                        }
                    }
                    int total = (int)(qty * ListProduct[i].Price);
                    if (qty > 0 && count == 0)
                    {
                        dataGridView2.Rows.Add(ListProduct[i].Name, qty, ListProduct[i].Price, total);
                    }
                   
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
