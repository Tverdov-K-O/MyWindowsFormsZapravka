using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClass_2
{

    public partial class Form1 : Form
    {
        Petrol petrol = new Petrol(); // класс бензин
        public Form1()
        {
            InitializeComponent();

            groupBoxPriceCocaCola.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            groupBox6.BackColor = Color.Transparent;

            comboBox2.Items.AddRange(petrol.Name);
            comboBox2.Text = comboBox2.Items[0].ToString();
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
                         $"\t{this.petrol.getPricebyIndex(comboBox2.SelectedIndex)} * {(Convert.ToDouble(PriceGroupBox_1.Text) / petrol.getDoublePriceByIndex(comboBox2.SelectedIndex)).ToString("0.00")} ЛИТР\t= {PriceGroupBox_1.Text}грн.\n";
            }
            if(checkHotDog.Enabled && numericUpDown1.Value != 0)
            {
                Check += $" {checkHotDog.Text}:\t\t{textBoxPriceHotdog.Text} * {numericUpDown1.Value}\t= {Convert.ToDouble(textBoxPriceHotdog.Text) * (double)numericUpDown1.Value}\tгрн.\n";
            }
            if(checkGamburger.Enabled && numericUpDown2.Value != 0)
            {
                Check += $" {checkGamburger.Text}:\t{textBoxPriceGamburger.Text} * {numericUpDown2.Value}\t= {Convert.ToDouble(textBoxPriceGamburger.Text) * (double)numericUpDown2.Value}\tгрн.\n";
            }
            if(checkFrenchFries.Enabled && numericUpDown3.Value != 0)
            {
                Check += $" {checkFrenchFries.Text}:\t{textBoxPriceFrenchFries.Text} * {numericUpDown3.Value}\t= {Convert.ToDouble(textBoxPriceFrenchFries.Text) * (double)numericUpDown3.Value}\tгрн.\n";
            }
            if(checkCocaCola.Enabled && numericUpDown4.Value != 0)
            {
                Check += $" {checkCocaCola.Text}:\t{textBoxCocaCola.Text} * {numericUpDown4.Value} = {Convert.ToDouble(textBoxCocaCola.Text) * (double)numericUpDown4.Value}\tгрн.\n";
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

        // чекбокс хотдог
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = !numericUpDown1.Enabled;
            numericUpDown1.Value = 0;
        }
        // чекбокс гамбургер
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = !numericUpDown2.Enabled;
            numericUpDown2.Value = 0;
        }
        // чекбокс картошка фри
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = !numericUpDown3.Enabled;
            numericUpDown3.Value = 0;
        }
        // чекбокс кола
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown4.Enabled = !numericUpDown4.Enabled;
            numericUpDown4.Value = 0;
        }

        // кол. продуктов
        private void numericUpDownValueChanged(object sender, EventArgs e)
        {
            double Price = 0;
            if (checkHotDog.Enabled == true)
            {
                Price += (int)numericUpDown1.Value * Convert.ToDouble(textBoxPriceHotdog.Text);
            }
            if (checkGamburger.Enabled == true)
            {
                Price += (int)numericUpDown2.Value * Convert.ToDouble(textBoxPriceGamburger.Text);
            }
            if (checkFrenchFries.Enabled == true)
            {
                Price += (int)numericUpDown3.Value * Convert.ToDouble(textBoxPriceFrenchFries.Text);
            }
            if (checkCocaCola.Enabled == true)
            {
                Price += (int)numericUpDown4.Value * Convert.ToDouble(textBoxCocaCola.Text);
            }
            PriceGroupBox_2.Text = Convert.ToString(Price);
            double fullPrice = Convert.ToDouble(PriceGroupBox_1.Text) + Convert.ToDouble(PriceGroupBox_2.Text);
            FullPrice.Text = Convert.ToString(fullPrice) + " грн.";
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
}
