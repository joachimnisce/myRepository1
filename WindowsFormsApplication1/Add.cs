using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty) //walang laman
            {
                MessageBox.Show("Please input name.");
                return;

            }
            if (textBox2.Text == string.Empty)
	        {
                MessageBox.Show("Please input contact number");
                return; //terminate function immediately
	        }
            
            DialogResult = DialogResult.OK;
            //public function to export values
            
        }
        public void export(out string name, out string contactNo)
        {
            name = textBox1.Text;
            contactNo = textBox2.Text;
        }
    }
}
