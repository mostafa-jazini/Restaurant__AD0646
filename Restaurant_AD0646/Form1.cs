using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Restaurant_AD0646
{
    public partial class Form1 : Form
        
    {
       
        private string username;
        public Form1()
        {
            InitializeComponent();

       

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(txtUsername.Text=="mostafa"&&txtPassword.Text=="12345")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                

            }*/
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\GTTCO\OneDrive\سطح المكتب\DB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from tb1_login Where username = '" + txtUsername.Text.Trim() + "' and password='" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                new Form2().Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Check your Username and password ");
               // txtUsername.Clear();
               // txtPassword.Clear();
               // txtUsername.Focus();
            }
        }

    }
}
