using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsClass_2
{

    public partial class Form1 : Form
    {
        Petrol petrol = new Petrol(); // класс бензин
        public List<Product> products = new List<Product>()
        {
            new Product("Хот-дог", 50),
            new Product("Гамбургер", 44.90),
            new Product("Карт.-фи", 29),
            new Product("Кока-кола", 17.90),
            new Product("Пиво",24.60),
            new Product("Вода",10.80),
            new Product("Жвачка",9.50),
            new Product("Булочка",15.40)
        };

        Product pd = new Product("Хот-дог", 50);
        public Form1()
        {
            InitializeComponent();
            

            groupBoxPriceCocaCola.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            groupBox6.BackColor = Color.Transparent;

            comboBox2.Items.AddRange(petrol.Name);
            comboBox2.Text = comboBox2.Items[0].ToString();

            for (int i = 0; i < products.Count; i++)
            {
                products[i]._CheckBox.Location      = new Point(0, 5 + i * 25);
                //
                products[i]._TextBox.Location       = new Point(110, 5 + i * 25);
                //
                products[i]._NumericUpDown.Location = new Point(175, 5 + i * 25);
                //
                panelProducts.Controls.Add(products[i]._CheckBox);
                panelProducts.Controls.Add(products[i]._TextBox);
                panelProducts.Controls.Add(products[i]._NumericUpDown);
                products[i]._CheckBox.CheckedChanged    += new System.EventHandler(this.checkBoxCheckedChanged);
                products[i]._NumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDownValueChanged);
            }
        }

        // комбо-бокс с названием бензина
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownCount.Value = 0;
            textBoxSum.Text = "";
            textBoxPricePetrol.Text = this.petrol.getPricebyIndex(comboBox2.SelectedIndex);
        }

        //вывод чека
        private void button2_Click_1(object sender, EventArgs e)
        {
            string Check = "\t         -Кассовый Чек-\n" +
                           "Николаевская обл., г.Николаев п-р Центрл.96\n" +
                           "Фн3000022534		ИД 37821544\n" +
                           "	ЧЕК № 59864875\n" +
                           "	КАСИР: БОЙКО А.Р.\n";
            if (numericUpDownCount.Value != 0 || textBoxSum.Text != "")
            {
                Check += $"ТОПЛИВО: {comboBox2.Items[comboBox2.SelectedIndex].ToString()}\n" +
                          "ЭВРО05-B0\n" +
                         $"\t{this.petrol.getPricebyIndex(comboBox2.SelectedIndex)} * {(Convert.ToDouble(PriceGroupBox_1.Text) / petrol.getDoublePriceByIndex(comboBox2.SelectedIndex)).ToString("0.00")} ЛИТР\t= {PriceGroupBox_1.Text}\tгрн.\n";
            }
            foreach (var item in products)
            {
                if (item._CountProduct > 0)
                {
                    Check += $" {item._CheckBox.Text}: \t{item._TextBox.Text} * {item._NumericUpDown.Value} = {Convert.ToDouble(item._TextBox.Text) * (double)item._NumericUpDown.Value}\tгрн.\n";
                }
            }
            Check += $"	СУММА {FullPrice.Text}\n" +
                     $"ДАТА: {DateTime.Now.ToShortDateString()}\t\tВРЕМЯ: {DateTime.Now.ToShortTimeString()}\n";
            MessageBox.Show(Check, "\t\tЧек", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            XmlSerializer formatter = new XmlSerializer(typeof(Product));

            var xmlFormater = new XmlSerializer(typeof(List<Product>));
            using(var file = new FileStream("groups.xml", FileMode.Create))
            {
                xmlFormater.Serialize(file, products);
            }

            
        }

        // радио кнопка количесво
        private void radioButtonCount_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSum.Enabled = false;
            PriceGroupBox_1.Text = "0";
            numericUpDownCount.Enabled = true;
        }
        //радио кнопка сумма
        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownCount.Enabled = false;
            numericUpDownCount.Value = 0;
            textBoxSum.Enabled = true;
        }

        // кнопка лит
        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            double Price = (double)numericUpDownCount.Value * petrol.getDoublePriceByIndex(comboBox2.SelectedIndex);
            PriceGroupBox_1.Text = Convert.ToString(Price);
            double fullPrice = Convert.ToDouble(PriceGroupBox_1.Text) + Convert.ToDouble(PriceGroupBox_2.Text);
            FullPrice.Text = Convert.ToString(fullPrice) + " грн.";
        }

        // тексбокс ввода суммы 
        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSum.Text != "")
            {
                PriceGroupBox_1.Text = textBoxSum.Text;
                double fullPrice = Convert.ToDouble(PriceGroupBox_1.Text) + Convert.ToDouble(PriceGroupBox_2.Text);
                FullPrice.Text = Convert.ToString(fullPrice) + " грн.";
            }
            else
            {
                PriceGroupBox_1.Text = "0";
                FullPrice.Text = PriceGroupBox_2.Text + " грн.";
            }
        }

        // чекбокс
        private void checkBoxCheckedChanged(object sender, EventArgs e)
        {
            foreach (Product item in products)
            {
                if(item._CheckBox.Focused)
                {
                    item._NumericUpDown.Enabled = !item._NumericUpDown.Enabled;
                    item._NumericUpDown.Value = 0; 
                }
            }
        }

        // кол. продуктов
        private void numericUpDownValueChanged(object sender, EventArgs e)
        {
            double Price = 0;
            foreach (Product item in products)
            {
                if (item._CheckBox.Checked)
                {
                    Price += (double)item._NumericUpDown.Value * item._Price;

                }

            }
            PriceGroupBox_2.Text = Convert.ToString(Price);
            double fullPrice = Convert.ToDouble(PriceGroupBox_1.Text) + Convert.ToDouble(PriceGroupBox_2.Text);
            FullPrice.Text = Convert.ToString(fullPrice) + " грн.";
        }

        private void panelProducts_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("..\\..\\jpg\\фон.png");
        }
    }
    class Petrol
     {
        public string[] Name { get; set; }  = { "A-92", "A-95", "95-MUSTANG", "100-MUSTANG"};
        public double[] Price { get; set; } = { 30.84, 31.82, 32.98, 35.21};
        public Petrol(){}

        public string getPricebyIndex(int index)
        {
            return Convert.ToString(Price[index]);
        }

        public double getDoublePriceByIndex(int index)
        {
            return Price[index];
        }
     }


    [Serializable]
    public class Product 
    {
        public  string        _Name          { get; set; } = "";
        public double         _Price         { get; set; } = 0;
        public  int           _CountProduct  { get { return (int)_NumericUpDown.Value;}}
        [NonSerialized]
        public  CheckBox      _CheckBox       = new CheckBox() { };
        [NonSerialized]
        public  TextBox       _TextBox        = new TextBox() { };
        [NonSerialized]
        public  NumericUpDown _NumericUpDown  = new NumericUpDown() { };

        public Product() 
        {
            _CheckBox.Text = _Name;
            _CheckBox.Size = new Size(110, 20);
            //
            _TextBox.ReadOnly = true;
            _TextBox.Text = _Price.ToString("0.00");
            _TextBox.Size = new Size(60, 20);
            _TextBox.RightToLeft = RightToLeft.Yes;
            _TextBox.ForeColor = Color.Black;
            _TextBox.BackColor = Color.Green;
            _TextBox.BorderStyle = BorderStyle.FixedSingle;
            //
            _NumericUpDown.Size = new Size(45, 22);
            _NumericUpDown.TextAlign = HorizontalAlignment.Right;
            _NumericUpDown.ForeColor = Color.Black;
            _NumericUpDown.BackColor = Color.Green;
            _NumericUpDown.Enabled = false;
        }
        public  Product(string n, double p) 
        {
            _Name  = n;
            _Price = p; 
            _CheckBox.Text = _Name;
            _CheckBox.Size = new Size(110, 20);
            //
            _TextBox.ReadOnly    = true;
            _TextBox.Text        = _Price.ToString("0.00");
            _TextBox.Size        = new Size(60, 20);
            _TextBox.RightToLeft = RightToLeft.Yes;
            _TextBox.ForeColor   = Color.Black;
            _TextBox.BackColor   = Color.Green;
            _TextBox.BorderStyle = BorderStyle.FixedSingle;
            //
            _NumericUpDown.Size      = new Size(45, 22);
            _NumericUpDown.TextAlign = HorizontalAlignment.Right;
            _NumericUpDown.ForeColor = Color.Black;
            _NumericUpDown.BackColor = Color.Green;
            _NumericUpDown.Enabled   = false;
            //

        }
    }
}

