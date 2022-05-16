using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_AD0646
{
    public partial class Form1 : Form
    {
        private string username;
        public Form1()
        {
            InitializeComponent();
        //    User.user1 = new Uesr(1. "mostafa jazini", "1234");
          //  User.user2 = new Uesr(2. "mohamad jazini", "1234");

            //UsersList.Add(user1);
//            UsersList.Add(user2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox3.Text;
            if(textBox2.Text=="mostafa"&&textBox3.Text=="12345")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                textBox2.Clear();
                textBox3.Clear();
                textBox2.Focus();
            }
        }
    }
}
