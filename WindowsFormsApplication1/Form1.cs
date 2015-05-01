using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 //namespace parang package. Package in java
{
    public partial class Form1 : Form
    {
        public string name;
        public string contactNo;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var xyz = new Add();
            if (xyz.ShowDialog() == DialogResult.OK)
	        {
                xyz.export(out name, out contactNo);
                listView1.Items.Add(this.name);
                listView1.Items[listView1.Items.Count -1].SubItems.Add(contactNo);

	        }
        
            
            
        }
        
    }
}
