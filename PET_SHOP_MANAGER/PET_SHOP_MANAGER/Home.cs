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

        private void Home_Load(object sender, EventArgs e)
        {
            using (var context = new PET_SHOP_MANAGERContext()) {
                List<InforAccount> info = context.InforAccounts.Where(x => x.Idacc == id).ToList();
                foreach (InforAccount emp in info)
                {
                    label12.Text = emp.Fullname;
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            Employee form = new Employee(id,role);
            form.Show();
        }
    }
}
