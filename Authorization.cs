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
    public partial class Authorization : Form
    {
        Dictionary<int,int> admin = new Dictionary<int, int>();
        Dictionary<int,int> user = new Dictionary<int, int>();
        public Authorization()
        {
            admin.Add("admin".GetHashCode(), "admin".GetHashCode());
            user.Add("user".GetHashCode(), "user".GetHashCode());
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text.Length > 0 && this.textBox2.Text.Length > 0)
            {
                bool starMainForm = true;
                foreach (var item in admin)
                {
                    if(item.Key == textBox1.Text.GetHashCode() && item.Value == textBox2.Text.GetHashCode())
                    {
                        this.DialogResult = DialogResult.OK;
                        starMainForm = false;
                    }
                }
                foreach (var item in user)
                {
                    if (item.Key == textBox1.Text.GetHashCode() && item.Value == textBox2.Text.GetHashCode())
                    {
                        this.DialogResult = DialogResult.Yes;
                        starMainForm = false;
                    }
                }
                if(starMainForm)
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Некорректно введены данные!", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
