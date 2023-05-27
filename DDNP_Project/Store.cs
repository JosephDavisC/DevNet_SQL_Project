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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Thank you for purchasing at DevNet!");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;


            }
            else if (checkBox2.Checked)
            {
                MessageBox.Show("Thank you for purchasing at DevNet!");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else if (checkBox3.Checked)
            {
                MessageBox.Show("Thank you for purchasing at DevNet!");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else if (checkBox4.Checked)
            {
                MessageBox.Show("Thank you for purchasing at DevNet!");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else if (checkBox5.Checked)
            {
                MessageBox.Show("Thank you for purchasing at DevNet!");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                MessageBox.Show("Choose The Item");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
