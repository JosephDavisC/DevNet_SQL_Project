using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDNP_Project
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeelogin f15 = new employeelogin();
            f15.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products f16 = new Products();
            f16.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerdata f17 = new customerdata();
            f17.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            productdetailemployee f18 = new productdetailemployee();
            f18.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payments f20 = new Payments();
            f20.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            company_data f21 = new company_data();
            f21.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders f22 = new Orders();
            f22.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            suppliers f24 = new suppliers();
            f24.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            shipperemployee f25 = new shipperemployee();
            f25.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productsupplier f26 = new Productsupplier();
            f26.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoicelines f27 = new Invoicelines();
            f27.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orderlines f30 = new Orderlines();
            f30.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoice f31 = new Invoice();
            f31.ShowDialog();
        }
    }
}
