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
        Authorization authorization      = new Authorization(); // класс авторизации
        Petrol petrol                    = new Petrol(); // класс бензин
        List<ProductsElem> productsElems = new List<ProductsElem>(); // лист елементов формы
        public List<Product> products    = Serialization<List<Product>>.DeSerializ("Products", "xml"); // лист продуктов
        public Form1()
        {
            if (authorization.ShowDialog() == DialogResult.Yes || authorization.DialogResult == DialogResult.OK)
            {
                InitializeComponent();
                groupBoxPriceCocaCola.BackColor = Color.Transparent;
                groupBox1.BackColor = Color.Transparent;
                groupBox6.BackColor = Color.Transparent;
                //
                comboBox2.Items.AddRange(petrol.Name);
                comboBox2.Text = comboBox2.Items[0].ToString();
                //
                restartProductList();
                if (authorization.DialogResult == DialogResult.OK)
                {
                    panelProducts.Size = new Size(panelProducts.Width, panelProducts.Height - 24);
                    //
                    Button add      = new Button();
                    add.Text        = "Добавить";
                    add.Location    = new Point(6, 210);
                    add.Size        = new Size(75, 23);
                    add.FlatStyle   = FlatStyle.Popup;
                    add.BackColor   = Color.MediumAquamarine;
                    add.Click       += new EventHandler(add_Click);
                    groupBoxPriceCocaCola.Controls.Add(add);
                    //
                    Button edit     = new Button();
                    edit.Text       = "Редакт.";
                    edit.Location   = new Point(87, 210);
                    edit.Size       = new Size(75, 23);
                    edit.FlatStyle  = FlatStyle.Popup;
                    edit.BackColor  = Color.MediumAquamarine;
                    edit.Click      += new EventHandler(edit_Click);
                    groupBoxPriceCocaCola.Controls.Add(edit);
                    //
                    Button dell     = new Button();
                    dell.Text       = "Удалить";
                    dell.Location   = new Point(168, 210);
                    dell.Size       = new Size(75, 23);
                    dell.FlatStyle  = FlatStyle.Popup;
                    dell.BackColor  = Color.MediumAquamarine;
                    dell.Click      += new EventHandler(dell_Click);
                    groupBoxPriceCocaCola.Controls.Add(dell);
                }
            }
            
        }

        // комбо-бокс с названием бензина
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownCount.Value = 0;
            textBoxSum.Text = "";
            textBoxPricePetrol.Text = this.petrol.getPricebyIndex(comboBox2.SelectedIndex);
        }
        // события кнопок добавить/редактировать/удалить
        private void add_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin("Добавление товара");
            if (admin.ShowDialog() == DialogResult.OK)
            {
                products.Add(new Product(admin._Name, admin._Price));
                productsElems.Add(new ProductsElem(admin._Name, admin._Price));
                restartProductList();
            }
        }
        private void edit_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin("Редактор");
            int ind = 0;
            for (int i = 0; i < productsElems.Count; i++)
                if (productsElems[i]._CheckBox.Checked)
                    ind++;
            if (ind == 1)
            {
                for (int i = 0; i < productsElems.Count; i++)
                {
                    if (productsElems[i]._CheckBox.Checked)
                    {
                        admin._Name = productsElems[i]._CheckBox.Text;
                        admin._Price = Convert.ToDouble(productsElems[i]._TextBox.Text);
                        if (admin.ShowDialog() == DialogResult.OK)
                        {
                            products[i]._Name = admin._Name;
                            products[i]._Price = admin._Price;
                            productsElems[i]._CheckBox.Text = products[i]._Name;
                            productsElems[i]._TextBox.Text = products[i]._Price.ToString("0.00");
                        }
                        break;
                    }
                }
                Serialization<List<Product>>.Serializ("Products", products, "xml");
            }
            else if(ind > 1)
            {
                MessageBox.Show("Выбрано больше одного элементa!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Выберите элемент!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dell_Click(object sender, EventArgs e)
        {
            int ind = 0;
                for (int i = 0; i < productsElems.Count; i++)
                {
                    if (productsElems[i]._CheckBox.Checked)
                    {
                    productsElems.RemoveAt(i);
                    products.RemoveAt(i);
                    ind++;
                    }
                }
              if(ind > 0)
                restartProductList();
            else 
                MessageBox.Show("Выберите элемент!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // вывод чека
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
            foreach (ProductsElem item in productsElems)
            {
                if (item._NumericUpDown.Value > 0)
                {
                    Check += $" {item._CheckBox.Text}:   \t{item._TextBox.Text} * {item._NumericUpDown.Value} = {Convert.ToDouble(item._TextBox.Text) * (double)item._NumericUpDown.Value}\tгрн.\n";
                }
            }
            Check += $"	СУММА {FullPrice.Text}\n" +
                     $"ДАТА: {DateTime.Now.ToShortDateString()}\t\tВРЕМЯ: {DateTime.Now.ToShortTimeString()}\n";
            MessageBox.Show(Check, "\t\tЧек", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        // радио кнопка количесво
        private void radioButtonCount_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSum.Enabled = false;
            PriceGroupBox_1.Text = "0";
            numericUpDownCount.Enabled = true;
        }
        // радио кнопка сумма
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
            foreach (ProductsElem item in productsElems)
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
            foreach (ProductsElem item in productsElems)
            {
                if (item._CheckBox.Checked)
                {
                    Price += (double)item._NumericUpDown.Value * Convert.ToDouble(item._TextBox.Text);

                }

            }
            PriceGroupBox_2.Text = Convert.ToString(Price);
            double fullPrice = Convert.ToDouble(PriceGroupBox_1.Text) + Convert.ToDouble(PriceGroupBox_2.Text);
            FullPrice.Text = Convert.ToString(fullPrice) + " грн.";
        }
        // событие прокрутки скрола
        private void panelProducts_Scroll(object sender, ScrollEventArgs e)
        {
            panelProducts.BackgroundImage = System.Drawing.Image.FromFile("..\\..\\jpg\\пнг.png");
        }
        // функция перезапуска панели с продуктами
        void restartProductList()
        {
            panelProducts.Controls.Clear();

            for (int i = 0; i < products.Count; i++)
            {
                productsElems.Add(new ProductsElem(products[i]._Name, products[i]._Price));
                productsElems[i]._CheckBox.Location = new Point(0, 5 + i * 25);
                //
                productsElems[i]._TextBox.Location = new Point(110, 5 + i * 25);
                //
                productsElems[i]._NumericUpDown.Location = new Point(175, 5 + i * 25);
                //
                panelProducts.Controls.Add(productsElems[i]._CheckBox);
                panelProducts.Controls.Add(productsElems[i]._TextBox);
                panelProducts.Controls.Add(productsElems[i]._NumericUpDown);
                productsElems[i]._CheckBox.CheckedChanged += new System.EventHandler(this.checkBoxCheckedChanged);
                productsElems[i]._NumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDownValueChanged);
            }
            Serialization<List<Product>>.Serializ("Products", products, "xml");
        }
    }

    // класс бензин
    class Petrol
     {
        public string[] Name  { get; set; }  = { "A-92", "A-95", "95-MUSTANG", "100-MUSTANG"};
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

    // класс елементов продукта
    class ProductsElem
    {
        public CheckBox _CheckBox           = new CheckBox() { };
        public TextBox _TextBox             = new TextBox() { };
        public NumericUpDown _NumericUpDown = new NumericUpDown() { };
        public ProductsElem(string Name, double Price)
        {
            _CheckBox.Text = Name;
            _CheckBox.Size = new Size(110, 20);
            //
            _TextBox.ReadOnly    = true;
            _TextBox.Text        = Price.ToString("0.00");
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
        }
    }

    // клас продукт создан для сериализации
    [Serializable]
    public class Product 
    {
        public  string  _Name   { get; set; }
        public  double  _Price  { get; set; }
        public Product() {}
        public  Product(string n, double p) 
        {
            _Name  = n;
            _Price = p; 
        }
    }
}

