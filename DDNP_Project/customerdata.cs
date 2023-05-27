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
    public partial class customerdata : Form
    {
        public customerdata()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin f8 = new admin();
            f8.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = @"server=localhost;user id=root;password=HighScope;database=devnet;allowuservariables=True;persistsecurityinfo=True";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into devnet.customers(CustomerID,ContactName,OfficePhone,MobilePhone,Email,Address,City,State,Country,PostalCode) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','"
                    + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "'); ";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = @"server=localhost;user id=root;password=HighScope;database=devnet;allowuservariables=True;persistsecurityinfo=True";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update devnet.customers set ContactName='" + this.textBox2.Text + "',OfficePhone='" + this.textBox3.Text + "'," +
                    "MobilePhone='" + this.textBox4.Text + "',Email='" + this.textBox5.Text + "',Address='" + this.textBox6.Text + "',City='" + this.textBox7.Text + "',State='" + this.textBox8.Text + "',Country='" + this.textBox9.Text + "',PostalCode='" + this.textBox10.Text + "' where CustomerID='" + this.textBox1.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();//Connection closed here
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = @"server=localhost;user id=root;password=HighScope;database=devnet;allowuservariables=True;persistsecurityinfo=True";
                string Query = "delete from devnet.customers where CustomerID='" + this.textBox1.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = @"server=localhost;user id=root;password=HighScope;database=devnet;allowuservariables=True;persistsecurityinfo=True";
                //Display query  
                string Query = "select * from devnet.customers;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
