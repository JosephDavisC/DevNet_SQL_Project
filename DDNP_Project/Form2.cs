using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DDNP_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shipperinfocustomer f3 = new Shipperinfocustomer();
            f3.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f6 = new Form1();
            f6.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvoiceAndPaymentCustomerSide f7 = new InvoiceAndPaymentCustomerSide();
            f7.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productdetails f8 = new Productdetails();
            f8.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerpage f50 = new customerpage();
            f50.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Store f2 = new Store();
            f2.ShowDialog();
        }
    }
}
