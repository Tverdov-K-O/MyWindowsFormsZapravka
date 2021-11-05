
namespace WindowsFormsClass_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.radioButtonCount = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceGroupBox_1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPricePetrol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPriceCocaCola = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkGamburger = new System.Windows.Forms.CheckBox();
            this.checkFrenchFries = new System.Windows.Forms.CheckBox();
            this.checkCocaCola = new System.Windows.Forms.CheckBox();
            this.checkHotDog = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceGroupBox_2 = new System.Windows.Forms.Label();
            this.textBoxPriceFrenchFries = new System.Windows.Forms.TextBox();
            this.textBoxPriceGamburger = new System.Windows.Forms.TextBox();
            this.textBoxPriceHotdog = new System.Windows.Forms.TextBox();
            this.textBoxCocaCola = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FullPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxPriceCocaCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.numericUpDownCount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxSum);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPricePetrol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.BackColor = System.Drawing.Color.Green;
            this.numericUpDownCount.Enabled = false;
            this.numericUpDownCount.Location = new System.Drawing.Point(133, 155);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownCount.TabIndex = 24;
            this.numericUpDownCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCount.ValueChanged += new System.EventHandler(this.numericUpDownCount_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(201, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "грн.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(201, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "л.";
            // 
            // textBoxSum
            // 
            this.textBoxSum.BackColor = System.Drawing.Color.Green;
            this.textBoxSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSum.Enabled = false;
            this.textBoxSum.Location = new System.Drawing.Point(133, 195);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(62, 22);
            this.textBoxSum.TabIndex = 8;
            this.textBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSum.TextChanged += new System.EventHandler(this.textBoxSum_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonSum);
            this.groupBox4.Controls.Add(this.radioButtonCount);
            this.groupBox4.Location = new System.Drawing.Point(6, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 91);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.AutoSize = true;
            this.radioButtonSum.Location = new System.Drawing.Point(6, 57);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(74, 20);
            this.radioButtonSum.TabIndex = 1;
            this.radioButtonSum.TabStop = true;
            this.radioButtonSum.Text = "Сумма";
            this.radioButtonSum.UseVisualStyleBackColor = true;
            this.radioButtonSum.CheckedChanged += new System.EventHandler(this.radioButtonSum_CheckedChanged);
            // 
            // radioButtonCount
            // 
            this.radioButtonCount.AutoSize = true;
            this.radioButtonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCount.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCount.Name = "radioButtonCount";
            this.radioButtonCount.Size = new System.Drawing.Size(114, 20);
            this.radioButtonCount.TabIndex = 0;
            this.radioButtonCount.TabStop = true;
            this.radioButtonCount.Text = "Количество";
            this.radioButtonCount.UseVisualStyleBackColor = true;
            this.radioButtonCount.CheckedChanged += new System.EventHandler(this.radioButtonCount_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.PriceGroupBox_1);
            this.groupBox3.Location = new System.Drawing.Point(6, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 88);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "К оплате:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "грн.";
            // 
            // PriceGroupBox_1
            // 
            this.PriceGroupBox_1.AutoSize = true;
            this.PriceGroupBox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceGroupBox_1.Location = new System.Drawing.Point(44, 28);
            this.PriceGroupBox_1.Name = "PriceGroupBox_1";
            this.PriceGroupBox_1.Size = new System.Drawing.Size(36, 37);
            this.PriceGroupBox_1.TabIndex = 0;
            this.PriceGroupBox_1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(148, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "грн.";
            // 
            // textBoxPricePetrol
            // 
            this.textBoxPricePetrol.BackColor = System.Drawing.Color.Green;
            this.textBoxPricePetrol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPricePetrol.Location = new System.Drawing.Point(73, 89);
            this.textBoxPricePetrol.Name = "textBoxPricePetrol";
            this.textBoxPricePetrol.ReadOnly = true;
            this.textBoxPricePetrol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPricePetrol.Size = new System.Drawing.Size(72, 22);
            this.textBoxPricePetrol.TabIndex = 3;
            this.textBoxPricePetrol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Green;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox2.Location = new System.Drawing.Point(73, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бензин:";
            // 
            // groupBoxPriceCocaCola
            // 
            this.groupBoxPriceCocaCola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxPriceCocaCola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxPriceCocaCola.BackgroundImage")));
            this.groupBoxPriceCocaCola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxPriceCocaCola.Controls.Add(this.numericUpDown4);
            this.groupBoxPriceCocaCola.Controls.Add(this.numericUpDown3);
            this.groupBoxPriceCocaCola.Controls.Add(this.numericUpDown2);
            this.groupBoxPriceCocaCola.Controls.Add(this.numericUpDown1);
            this.groupBoxPriceCocaCola.Controls.Add(this.label9);
            this.groupBoxPriceCocaCola.Controls.Add(this.label8);
            this.groupBoxPriceCocaCola.Controls.Add(this.checkGamburger);
            this.groupBoxPriceCocaCola.Controls.Add(this.checkFrenchFries);
            this.groupBoxPriceCocaCola.Controls.Add(this.checkCocaCola);
            this.groupBoxPriceCocaCola.Controls.Add(this.checkHotDog);
            this.groupBoxPriceCocaCola.Controls.Add(this.groupBox5);
            this.groupBoxPriceCocaCola.Controls.Add(this.textBoxPriceFrenchFries);
            this.groupBoxPriceCocaCola.Controls.Add(this.textBoxPriceGamburger);
            this.groupBoxPriceCocaCola.Controls.Add(this.textBoxPriceHotdog);
            this.groupBoxPriceCocaCola.Controls.Add(this.textBoxCocaCola);
            this.groupBoxPriceCocaCola.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBoxPriceCocaCola.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxPriceCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPriceCocaCola.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxPriceCocaCola.Location = new System.Drawing.Point(286, 12);
            this.groupBoxPriceCocaCola.Name = "groupBoxPriceCocaCola";
            this.groupBoxPriceCocaCola.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxPriceCocaCola.Size = new System.Drawing.Size(245, 329);
            this.groupBoxPriceCocaCola.TabIndex = 1;
            this.groupBoxPriceCocaCola.TabStop = false;
            this.groupBoxPriceCocaCola.Text = "Мини-Кафе";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.Green;
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Location = new System.Drawing.Point(177, 160);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown4.TabIndex = 26;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDownValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.Green;
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(177, 128);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown3.TabIndex = 25;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDownValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.Green;
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(177, 92);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown2.TabIndex = 24;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDownValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Green;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(177, 59);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDownValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(176, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Кол.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(118, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Цена:";
            // 
            // checkGamburger
            // 
            this.checkGamburger.AutoSize = true;
            this.checkGamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checkGamburger.Location = new System.Drawing.Point(7, 92);
            this.checkGamburger.Name = "checkGamburger";
            this.checkGamburger.Size = new System.Drawing.Size(97, 20);
            this.checkGamburger.TabIndex = 20;
            this.checkGamburger.Text = "Гамбургер";
            this.checkGamburger.UseVisualStyleBackColor = true;
            this.checkGamburger.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkFrenchFries
            // 
            this.checkFrenchFries.AutoSize = true;
            this.checkFrenchFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checkFrenchFries.Location = new System.Drawing.Point(7, 128);
            this.checkFrenchFries.Name = "checkFrenchFries";
            this.checkFrenchFries.Size = new System.Drawing.Size(95, 20);
            this.checkFrenchFries.TabIndex = 19;
            this.checkFrenchFries.Text = "Карт.- фри";
            this.checkFrenchFries.UseVisualStyleBackColor = true;
            this.checkFrenchFries.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkCocaCola
            // 
            this.checkCocaCola.AutoSize = true;
            this.checkCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checkCocaCola.Location = new System.Drawing.Point(7, 160);
            this.checkCocaCola.Name = "checkCocaCola";
            this.checkCocaCola.Size = new System.Drawing.Size(93, 20);
            this.checkCocaCola.TabIndex = 18;
            this.checkCocaCola.Text = "Кока-кола";
            this.checkCocaCola.UseVisualStyleBackColor = true;
            this.checkCocaCola.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkHotDog
            // 
            this.checkHotDog.AutoSize = true;
            this.checkHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkHotDog.Location = new System.Drawing.Point(7, 59);
            this.checkHotDog.Name = "checkHotDog";
            this.checkHotDog.Size = new System.Drawing.Size(76, 20);
            this.checkHotDog.TabIndex = 17;
            this.checkHotDog.Text = "Хот-дог";
            this.checkHotDog.UseVisualStyleBackColor = true;
            this.checkHotDog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.PriceGroupBox_2);
            this.groupBox5.Location = new System.Drawing.Point(6, 235);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 88);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "К оплате:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "грн.";
            // 
            // PriceGroupBox_2
            // 
            this.PriceGroupBox_2.AutoSize = true;
            this.PriceGroupBox_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceGroupBox_2.Location = new System.Drawing.Point(41, 29);
            this.PriceGroupBox_2.Name = "PriceGroupBox_2";
            this.PriceGroupBox_2.Size = new System.Drawing.Size(36, 37);
            this.PriceGroupBox_2.TabIndex = 0;
            this.PriceGroupBox_2.Text = "0";
            // 
            // textBoxPriceFrenchFries
            // 
            this.textBoxPriceFrenchFries.BackColor = System.Drawing.Color.Green;
            this.textBoxPriceFrenchFries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPriceFrenchFries.Location = new System.Drawing.Point(109, 128);
            this.textBoxPriceFrenchFries.Name = "textBoxPriceFrenchFries";
            this.textBoxPriceFrenchFries.ReadOnly = true;
            this.textBoxPriceFrenchFries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPriceFrenchFries.Size = new System.Drawing.Size(62, 22);
            this.textBoxPriceFrenchFries.TabIndex = 14;
            this.textBoxPriceFrenchFries.Text = "29";
            // 
            // textBoxPriceGamburger
            // 
            this.textBoxPriceGamburger.BackColor = System.Drawing.Color.Green;
            this.textBoxPriceGamburger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPriceGamburger.Location = new System.Drawing.Point(109, 92);
            this.textBoxPriceGamburger.Name = "textBoxPriceGamburger";
            this.textBoxPriceGamburger.ReadOnly = true;
            this.textBoxPriceGamburger.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPriceGamburger.Size = new System.Drawing.Size(62, 22);
            this.textBoxPriceGamburger.TabIndex = 13;
            this.textBoxPriceGamburger.Text = "44,90";
            // 
            // textBoxPriceHotdog
            // 
            this.textBoxPriceHotdog.BackColor = System.Drawing.Color.Green;
            this.textBoxPriceHotdog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPriceHotdog.Location = new System.Drawing.Point(109, 59);
            this.textBoxPriceHotdog.Name = "textBoxPriceHotdog";
            this.textBoxPriceHotdog.ReadOnly = true;
            this.textBoxPriceHotdog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPriceHotdog.Size = new System.Drawing.Size(62, 22);
            this.textBoxPriceHotdog.TabIndex = 12;
            this.textBoxPriceHotdog.Text = "50";
            // 
            // textBoxCocaCola
            // 
            this.textBoxCocaCola.BackColor = System.Drawing.Color.Green;
            this.textBoxCocaCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCocaCola.Location = new System.Drawing.Point(109, 160);
            this.textBoxCocaCola.Name = "textBoxCocaCola";
            this.textBoxCocaCola.ReadOnly = true;
            this.textBoxCocaCola.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCocaCola.Size = new System.Drawing.Size(62, 22);
            this.textBoxCocaCola.TabIndex = 8;
            this.textBoxCocaCola.Text = "17,90";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox6.BackgroundImage")));
            this.groupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.FullPrice);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(12, 369);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(519, 181);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Всего к оплате";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(6, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 154);
            this.button2.TabIndex = 3;
            this.button2.Text = "Получить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FullPrice
            // 
            this.FullPrice.AutoSize = true;
            this.FullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullPrice.Location = new System.Drawing.Point(274, 97);
            this.FullPrice.Name = "FullPrice";
            this.FullPrice.Size = new System.Drawing.Size(40, 42);
            this.FullPrice.TabIndex = 2;
            this.FullPrice.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 565);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBoxPriceCocaCola);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WOG";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxPriceCocaCola.ResumeLayout(false);
            this.groupBoxPriceCocaCola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPriceCocaCola;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPricePetrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonSum;
        private System.Windows.Forms.RadioButton radioButtonCount;
        private System.Windows.Forms.Label PriceGroupBox_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.CheckBox checkGamburger;
        private System.Windows.Forms.CheckBox checkFrenchFries;
        private System.Windows.Forms.CheckBox checkCocaCola;
        private System.Windows.Forms.CheckBox checkHotDog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label PriceGroupBox_2;
        private System.Windows.Forms.TextBox textBoxPriceFrenchFries;
        private System.Windows.Forms.TextBox textBoxPriceGamburger;
        private System.Windows.Forms.TextBox textBoxPriceHotdog;
        private System.Windows.Forms.TextBox textBoxCocaCola;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label FullPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

