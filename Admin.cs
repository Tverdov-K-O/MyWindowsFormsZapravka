using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClass_2
{
    public partial class Admin : Form
    {
        public string _Name  
        { 
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public double _Price 
        { 
            get { return Convert.ToDouble(textBox2.Text); }
            set { textBox2.Text = value.ToString("00.0"); }
        }
        public Admin(string name)
        {
            this.Text = name;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
