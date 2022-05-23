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
    public partial class FistCustomControl : UserControl
    {
        public FistCustomControl()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        internal class Show
        {
            public Show()
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The price of the meal is 25 JD .");
        }
    }
}
