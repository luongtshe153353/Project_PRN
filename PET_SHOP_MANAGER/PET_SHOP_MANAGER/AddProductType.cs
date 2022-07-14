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
    public partial class AddProductType : Form
    {
        int id;
        int role;

        public AddProductType(int id,int role)
        {
            this.id = id;
            this.role = role;
            InitializeComponent();
        }

        private void AddProductType_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var context = new PET_SHOP_MANAGERContext())
            {
                List<TypeProduct> list = context.TypeProducts.ToList();
                TypeProduct type = new TypeProduct();
                type.Name = textBox1.Text;
                type.Status = true;
                context.TypeProducts.Add(type);
                context.SaveChanges();
                MessageBox.Show("Add Thanh Cong");
                this.Close();
                frmProduct form = new frmProduct(id,role);
            }
        }
    }
}
