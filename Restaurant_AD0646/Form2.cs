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
    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            fistCustomControl1.BringToFront();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            fistCustomControl1.BringToFront();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            my2nd1.BringToFront();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void my2nd1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fistCustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void my2nd1_Load_1(object sender, EventArgs e)
        {
         
        }
    }
}
