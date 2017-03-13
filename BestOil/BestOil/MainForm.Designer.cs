namespace BestOil
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.labelRUB1 = new System.Windows.Forms.Label();
            this.textBoxPriceOfFuel1 = new System.Windows.Forms.TextBox();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelRubSumOrFuel = new System.Windows.Forms.Label();
            this.textBoxSumOrFuel = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelRUB2 = new System.Windows.Forms.Label();
            this.labelLiters = new System.Windows.Forms.Label();
            this.textBoxPriceOfFuel2 = new System.Windows.Forms.TextBox();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.textBoxQuantityOfFuel = new System.Windows.Forms.TextBox();
            this.radioButtonQuantity = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice2 = new System.Windows.Forms.Label();
            this.textBoxQuantityOfCocaCola = new System.Windows.Forms.TextBox();
            this.textBoxQuantityOfCheeseburger = new System.Windows.Forms.TextBox();
            this.textBoxQuantityOfHamburger = new System.Windows.Forms.TextBox();
            this.textBoxQuantityOfHotDog = new System.Windows.Forms.TextBox();
            this.labelRUB6 = new System.Windows.Forms.Label();
            this.labelRUB5 = new System.Windows.Forms.Label();
            this.labelRUB4 = new System.Windows.Forms.Label();
            this.labelRUB3 = new System.Windows.Forms.Label();
            this.textBoxPriceOfCocaCola = new System.Windows.Forms.TextBox();
            this.textBoxPriceOfCheeseburger = new System.Windows.Forms.TextBox();
            this.textBoxPriceOfHamburger = new System.Windows.Forms.TextBox();
            this.textBoxPriceOfHotDog = new System.Windows.Forms.TextBox();
            this.checkBoxCocaCola = new System.Windows.Forms.CheckBox();
            this.checkBoxCheeseburger = new System.Windows.Forms.CheckBox();
            this.checkBoxHamburger = new System.Windows.Forms.CheckBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxSumOfCafe = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelRubSumOfCafe = new System.Windows.Forms.Label();
            this.labelRubSum = new System.Windows.Forms.Label();
            this.labelTotalSum = new System.Windows.Forms.Label();
            this.labelRubTotalSum = new System.Windows.Forms.Label();
            this.textBoxTotalSum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFuel);
            this.groupBox1.Controls.Add(this.labelRUB1);
            this.groupBox1.Controls.Add(this.textBoxPriceOfFuel1);
            this.groupBox1.Controls.Add(this.labelPrice1);
            this.groupBox1.Controls.Add(this.labelFuel);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Топливо";
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Location = new System.Drawing.Point(100, 23);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(145, 21);
            this.comboBoxFuel.TabIndex = 7;
            this.comboBoxFuel.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuel_SelectedIndexChanged);
            // 
            // labelRUB1
            // 
            this.labelRUB1.AutoSize = true;
            this.labelRUB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRUB1.ForeColor = System.Drawing.Color.Red;
            this.labelRUB1.Location = new System.Drawing.Point(251, 60);
            this.labelRUB1.Name = "labelRUB1";
            this.labelRUB1.Size = new System.Drawing.Size(31, 13);
            this.labelRUB1.TabIndex = 6;
            this.labelRUB1.Text = "руб.";
            // 
            // textBoxPriceOfFuel1
            // 
            this.textBoxPriceOfFuel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceOfFuel1.Location = new System.Drawing.Point(100, 57);
            this.textBoxPriceOfFuel1.Name = "textBoxPriceOfFuel1";
            this.textBoxPriceOfFuel1.ReadOnly = true;
            this.textBoxPriceOfFuel1.Size = new System.Drawing.Size(145, 20);
            this.textBoxPriceOfFuel1.TabIndex = 5;
            this.textBoxPriceOfFuel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPrice1
            // 
            this.labelPrice1.AutoSize = true;
            this.labelPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice1.ForeColor = System.Drawing.Color.Red;
            this.labelPrice1.Location = new System.Drawing.Point(31, 60);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.Size = new System.Drawing.Size(37, 13);
            this.labelPrice1.TabIndex = 3;
            this.labelPrice1.Text = "Цена";
            this.toolTip1.SetToolTip(this.labelPrice1, "dsdasdas");
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelFuel.Location = new System.Drawing.Point(31, 26);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(50, 13);
            this.labelFuel.TabIndex = 2;
            this.labelFuel.Text = "Бензин";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelRubSumOrFuel);
            this.groupBox4.Controls.Add(this.textBoxSumOrFuel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(6, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "К оплате";
            // 
            // labelRubSumOrFuel
            // 
            this.labelRubSumOrFuel.AutoSize = true;
            this.labelRubSumOrFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRubSumOrFuel.Location = new System.Drawing.Point(237, 38);
            this.labelRubSumOrFuel.Name = "labelRubSumOrFuel";
            this.labelRubSumOrFuel.Size = new System.Drawing.Size(50, 24);
            this.labelRubSumOrFuel.TabIndex = 1;
            this.labelRubSumOrFuel.Text = "руб.";
            // 
            // textBoxSumOrFuel
            // 
            this.textBoxSumOrFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumOrFuel.Location = new System.Drawing.Point(19, 28);
            this.textBoxSumOrFuel.Name = "textBoxSumOrFuel";
            this.textBoxSumOrFuel.ReadOnly = true;
            this.textBoxSumOrFuel.Size = new System.Drawing.Size(212, 49);
            this.textBoxSumOrFuel.TabIndex = 0;
            this.textBoxSumOrFuel.Text = "0";
            this.textBoxSumOrFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelRUB2);
            this.groupBox3.Controls.Add(this.labelLiters);
            this.groupBox3.Controls.Add(this.textBoxPriceOfFuel2);
            this.groupBox3.Controls.Add(this.radioButtonSum);
            this.groupBox3.Controls.Add(this.textBoxQuantityOfFuel);
            this.groupBox3.Controls.Add(this.radioButtonQuantity);
            this.groupBox3.Location = new System.Drawing.Point(6, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // labelRUB2
            // 
            this.labelRUB2.AutoSize = true;
            this.labelRUB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRUB2.Location = new System.Drawing.Point(245, 64);
            this.labelRUB2.Name = "labelRUB2";
            this.labelRUB2.Size = new System.Drawing.Size(31, 13);
            this.labelRUB2.TabIndex = 9;
            this.labelRUB2.Text = "руб.";
            // 
            // labelLiters
            // 
            this.labelLiters.AutoSize = true;
            this.labelLiters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLiters.Location = new System.Drawing.Point(246, 30);
            this.labelLiters.Name = "labelLiters";
            this.labelLiters.Size = new System.Drawing.Size(18, 13);
            this.labelLiters.TabIndex = 7;
            this.labelLiters.Text = "л.";
            // 
            // textBoxPriceOfFuel2
            // 
            this.textBoxPriceOfFuel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceOfFuel2.Location = new System.Drawing.Point(106, 61);
            this.textBoxPriceOfFuel2.Name = "textBoxPriceOfFuel2";
            this.textBoxPriceOfFuel2.Size = new System.Drawing.Size(133, 20);
            this.textBoxPriceOfFuel2.TabIndex = 8;
            this.textBoxPriceOfFuel2.Text = "0";
            this.textBoxPriceOfFuel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPriceOfFuel2.TextChanged += new System.EventHandler(this.textBoxPriceOfFuel2_TextChanged);
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.AutoSize = true;
            this.radioButtonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSum.Location = new System.Drawing.Point(6, 62);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(64, 17);
            this.radioButtonSum.TabIndex = 1;
            this.radioButtonSum.TabStop = true;
            this.radioButtonSum.Text = "Сумма";
            this.radioButtonSum.UseVisualStyleBackColor = true;
            this.radioButtonSum.CheckedChanged += new System.EventHandler(this.radioButtonSum_CheckedChanged);
            // 
            // textBoxQuantityOfFuel
            // 
            this.textBoxQuantityOfFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantityOfFuel.Location = new System.Drawing.Point(106, 27);
            this.textBoxQuantityOfFuel.Name = "textBoxQuantityOfFuel";
            this.textBoxQuantityOfFuel.Size = new System.Drawing.Size(133, 20);
            this.textBoxQuantityOfFuel.TabIndex = 7;
            this.textBoxQuantityOfFuel.Text = "0";
            this.textBoxQuantityOfFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxQuantityOfFuel, "qeqweqeqe");
            this.textBoxQuantityOfFuel.TextChanged += new System.EventHandler(this.textBoxQuantityOfFuel_TextChanged);
            // 
            // radioButtonQuantity
            // 
            this.radioButtonQuantity.AutoSize = true;
            this.radioButtonQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonQuantity.Location = new System.Drawing.Point(6, 28);
            this.radioButtonQuantity.Name = "radioButtonQuantity";
            this.radioButtonQuantity.Size = new System.Drawing.Size(94, 17);
            this.radioButtonQuantity.TabIndex = 0;
            this.radioButtonQuantity.TabStop = true;
            this.radioButtonQuantity.Text = "Количество";
            this.radioButtonQuantity.UseVisualStyleBackColor = true;
            this.radioButtonQuantity.CheckedChanged += new System.EventHandler(this.radioButtonQuantity_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelQuantity);
            this.groupBox2.Controls.Add(this.labelPrice2);
            this.groupBox2.Controls.Add(this.textBoxQuantityOfCocaCola);
            this.groupBox2.Controls.Add(this.textBoxQuantityOfCheeseburger);
            this.groupBox2.Controls.Add(this.textBoxQuantityOfHamburger);
            this.groupBox2.Controls.Add(this.textBoxQuantityOfHotDog);
            this.groupBox2.Controls.Add(this.labelRUB6);
            this.groupBox2.Controls.Add(this.labelRUB5);
            this.groupBox2.Controls.Add(this.labelRUB4);
            this.groupBox2.Controls.Add(this.labelRUB3);
            this.groupBox2.Controls.Add(this.textBoxPriceOfCocaCola);
            this.groupBox2.Controls.Add(this.textBoxPriceOfCheeseburger);
            this.groupBox2.Controls.Add(this.textBoxPriceOfHamburger);
            this.groupBox2.Controls.Add(this.textBoxPriceOfHotDog);
            this.groupBox2.Controls.Add(this.checkBoxCocaCola);
            this.groupBox2.Controls.Add(this.checkBoxCheeseburger);
            this.groupBox2.Controls.Add(this.checkBoxHamburger);
            this.groupBox2.Controls.Add(this.checkBoxHotDog);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(323, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мини-кафе";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelQuantity.Location = new System.Drawing.Point(219, 16);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 13);
            this.labelQuantity.TabIndex = 22;
            this.labelQuantity.Text = "Количество";
            // 
            // labelPrice2
            // 
            this.labelPrice2.AutoSize = true;
            this.labelPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice2.ForeColor = System.Drawing.Color.Red;
            this.labelPrice2.Location = new System.Drawing.Point(115, 16);
            this.labelPrice2.Name = "labelPrice2";
            this.labelPrice2.Size = new System.Drawing.Size(37, 13);
            this.labelPrice2.TabIndex = 21;
            this.labelPrice2.Text = "Цена";
            // 
            // textBoxQuantityOfCocaCola
            // 
            this.textBoxQuantityOfCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantityOfCocaCola.Location = new System.Drawing.Point(222, 146);
            this.textBoxQuantityOfCocaCola.Name = "textBoxQuantityOfCocaCola";
            this.textBoxQuantityOfCocaCola.Size = new System.Drawing.Size(68, 20);
            this.textBoxQuantityOfCocaCola.TabIndex = 20;
            this.textBoxQuantityOfCocaCola.Text = "1";
            this.textBoxQuantityOfCocaCola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxQuantityOfCocaCola.TextChanged += new System.EventHandler(this.checkBoxHotDog_Click);
            // 
            // textBoxQuantityOfCheeseburger
            // 
            this.textBoxQuantityOfCheeseburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantityOfCheeseburger.Location = new System.Drawing.Point(222, 108);
            this.textBoxQuantityOfCheeseburger.Name = "textBoxQuantityOfCheeseburger";
            this.textBoxQuantityOfCheeseburger.Size = new System.Drawing.Size(68, 20);
            this.textBoxQuantityOfCheeseburger.TabIndex = 19;
            this.textBoxQuantityOfCheeseburger.Text = "1";
            this.textBoxQuantityOfCheeseburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxQuantityOfCheeseburger.TextChanged += new System.EventHandler(this.checkBoxHotDog_Click);
            // 
            // textBoxQuantityOfHamburger
            // 
            this.textBoxQuantityOfHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantityOfHamburger.Location = new System.Drawing.Point(222, 72);
            this.textBoxQuantityOfHamburger.Name = "textBoxQuantityOfHamburger";
            this.textBoxQuantityOfHamburger.Size = new System.Drawing.Size(68, 20);
            this.textBoxQuantityOfHamburger.TabIndex = 18;
            this.textBoxQuantityOfHamburger.Text = "1";
            this.textBoxQuantityOfHamburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxQuantityOfHamburger.TextChanged += new System.EventHandler(this.checkBoxHotDog_Click);
            // 
            // textBoxQuantityOfHotDog
            // 
            this.textBoxQuantityOfHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantityOfHotDog.Location = new System.Drawing.Point(222, 36);
            this.textBoxQuantityOfHotDog.Name = "textBoxQuantityOfHotDog";
            this.textBoxQuantityOfHotDog.Size = new System.Drawing.Size(68, 20);
            this.textBoxQuantityOfHotDog.TabIndex = 17;
            this.textBoxQuantityOfHotDog.Text = "1";
            this.textBoxQuantityOfHotDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxQuantityOfHotDog.TextChanged += new System.EventHandler(this.checkBoxHotDog_Click);
            // 
            // labelRUB6
            // 
            this.labelRUB6.AutoSize = true;
            this.labelRUB6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRUB6.ForeColor = System.Drawing.Color.Red;
            this.labelRUB6.Location = new System.Drawing.Point(175, 149);
            this.labelRUB6.Name = "labelRUB6";
            this.labelRUB6.Size = new System.Drawing.Size(31, 13);
            this.labelRUB6.TabIndex = 16;
            this.labelRUB6.Text = "руб.";
            // 
            // labelRUB5
            // 
            this.labelRUB5.AutoSize = true;
            this.labelRUB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRUB5.ForeColor = System.Drawing.Color.Red;
            this.labelRUB5.Location = new System.Drawing.Point(175, 111);
            this.labelRUB5.Name = "labelRUB5";
            this.labelRUB5.Size = new System.Drawing.Size(31, 13);
            this.labelRUB5.TabIndex = 15;
            this.labelRUB5.Text = "руб.";
            // 
            // labelRUB4
            // 
            this.labelRUB4.AutoSize = true;
            this.labelRUB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRUB4.ForeColor = System.Drawing.Color.Red;
            this.labelRUB4.Location = new System.Drawing.Point(175, 75);
            this.labelRUB4.Name = "labelRUB4";
            this.labelRUB4.Size = new System.Drawing.Size(31, 13);
            this.labelRUB4.TabIndex = 14;
            this.labelRUB4.Text = "руб.";
            // 
            // labelRUB3
            // 
            this.labelRUB3.AutoSize = true;
            this.labelRUB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRUB3.ForeColor = System.Drawing.Color.Red;
            this.labelRUB3.Location = new System.Drawing.Point(175, 39);
            this.labelRUB3.Name = "labelRUB3";
            this.labelRUB3.Size = new System.Drawing.Size(31, 13);
            this.labelRUB3.TabIndex = 8;
            this.labelRUB3.Text = "руб.";
            // 
            // textBoxPriceOfCocaCola
            // 
            this.textBoxPriceOfCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceOfCocaCola.Location = new System.Drawing.Point(101, 146);
            this.textBoxPriceOfCocaCola.Name = "textBoxPriceOfCocaCola";
            this.textBoxPriceOfCocaCola.ReadOnly = true;
            this.textBoxPriceOfCocaCola.Size = new System.Drawing.Size(68, 20);
            this.textBoxPriceOfCocaCola.TabIndex = 13;
            this.textBoxPriceOfCocaCola.Text = "1,5";
            this.textBoxPriceOfCocaCola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPriceOfCheeseburger
            // 
            this.textBoxPriceOfCheeseburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceOfCheeseburger.Location = new System.Drawing.Point(101, 108);
            this.textBoxPriceOfCheeseburger.Name = "textBoxPriceOfCheeseburger";
            this.textBoxPriceOfCheeseburger.ReadOnly = true;
            this.textBoxPriceOfCheeseburger.Size = new System.Drawing.Size(68, 20);
            this.textBoxPriceOfCheeseburger.TabIndex = 12;
            this.textBoxPriceOfCheeseburger.Text = "1,7";
            this.textBoxPriceOfCheeseburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPriceOfHamburger
            // 
            this.textBoxPriceOfHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceOfHamburger.Location = new System.Drawing.Point(101, 72);
            this.textBoxPriceOfHamburger.Name = "textBoxPriceOfHamburger";
            this.textBoxPriceOfHamburger.ReadOnly = true;
            this.textBoxPriceOfHamburger.Size = new System.Drawing.Size(68, 20);
            this.textBoxPriceOfHamburger.TabIndex = 11;
            this.textBoxPriceOfHamburger.Text = "1,5";
            this.textBoxPriceOfHamburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPriceOfHotDog
            // 
            this.textBoxPriceOfHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceOfHotDog.Location = new System.Drawing.Point(101, 36);
            this.textBoxPriceOfHotDog.Name = "textBoxPriceOfHotDog";
            this.textBoxPriceOfHotDog.ReadOnly = true;
            this.textBoxPriceOfHotDog.Size = new System.Drawing.Size(68, 20);
            this.textBoxPriceOfHotDog.TabIndex = 10;
            this.textBoxPriceOfHotDog.Text = "2";
            this.textBoxPriceOfHotDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxCocaCola
            // 
            this.checkBoxCocaCola.AutoSize = true;
            this.checkBoxCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCocaCola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkBoxCocaCola.Location = new System.Drawing.Point(15, 148);
            this.checkBoxCocaCola.Name = "checkBoxCocaCola";
            this.checkBoxCocaCola.Size = new System.Drawing.Size(87, 17);
            this.checkBoxCocaCola.TabIndex = 6;
            this.checkBoxCocaCola.Text = "Кока-кола";
            this.checkBoxCocaCola.UseVisualStyleBackColor = true;
            this.checkBoxCocaCola.Click += new System.EventHandler(this.checkBoxHotDog_Click);
            // 
            // checkBoxCheeseburger
            // 
            this.checkBoxCheeseburger.AutoSize = true;
            this.checkBoxCheeseburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCheeseburger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkBoxCheeseburger.Location = new System.Drawing.Point(15, 110);
            this.checkBoxCheeseburger.Name = "checkBoxCheeseburger";
            this.checkBoxCheeseburger.Size = new System.Drawing.Size(89, 17);
            this.checkBoxCheeseburger.TabIndex = 5;
            this.checkBoxCheeseburger.Text = "Чизбургер";
            this.checkBoxCheeseburger.UseVisualStyleBackColor = true;
            this.checkBoxCheeseburger.Click += new System.EventHandler(this.checkBoxHotDog_Click);
            // 
            // checkBoxHamburger
            // 
            this.checkBoxHamburger.AutoSize = true;
            this.checkBoxHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHamburger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkBoxHamburger.Location = new System.Drawing.Point(15, 74);
            this.checkBoxHamburger.Name = "checkBoxHamburger";
            this.checkBoxHamburger.Size = new System.Drawing.Size(89, 17);
            this.checkBoxHamburger.TabIndex = 4;
            this.checkBoxHamburger.Text = "Гамбургер";
            this.checkBoxHamburger.UseVisualStyleBackColor = true;
            this.checkBoxHamburger.Click += new System.EventHandler(this.checkBoxHotDog_Click);
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHotDog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkBoxHotDog.Location = new System.Drawing.Point(15, 38);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(71, 17);
            this.checkBoxHotDog.TabIndex = 3;
            this.checkBoxHotDog.Text = "Хот-дог";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.Click += new System.EventHandler(this.checkBoxHotDog_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelRubSumOfCafe);
            this.groupBox5.Controls.Add(this.textBoxSumOfCafe);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(6, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "К оплате";
            // 
            // textBoxSumOfCafe
            // 
            this.textBoxSumOfCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumOfCafe.Location = new System.Drawing.Point(18, 28);
            this.textBoxSumOfCafe.Name = "textBoxSumOfCafe";
            this.textBoxSumOfCafe.ReadOnly = true;
            this.textBoxSumOfCafe.Size = new System.Drawing.Size(212, 49);
            this.textBoxSumOfCafe.TabIndex = 1;
            this.textBoxSumOfCafe.Text = "0";
            this.textBoxSumOfCafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum.Location = new System.Drawing.Point(369, 353);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(190, 49);
            this.textBoxSum.TabIndex = 2;
            this.textBoxSum.Text = "0";
            this.textBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.Red;
            this.buttonCalculate.Location = new System.Drawing.Point(46, 345);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(165, 64);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Рассчитать";
            this.toolTip1.SetToolTip(this.buttonCalculate, "dddddd");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelSum.Location = new System.Drawing.Point(238, 364);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(130, 33);
            this.labelSum.TabIndex = 4;
            this.labelSum.Text = "ИТОГО:";
            // 
            // labelRubSumOfCafe
            // 
            this.labelRubSumOfCafe.AutoSize = true;
            this.labelRubSumOfCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRubSumOfCafe.Location = new System.Drawing.Point(236, 38);
            this.labelRubSumOfCafe.Name = "labelRubSumOfCafe";
            this.labelRubSumOfCafe.Size = new System.Drawing.Size(50, 24);
            this.labelRubSumOfCafe.TabIndex = 2;
            this.labelRubSumOfCafe.Text = "руб.";
            // 
            // labelRubSum
            // 
            this.labelRubSum.AutoSize = true;
            this.labelRubSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRubSum.Location = new System.Drawing.Point(565, 364);
            this.labelRubSum.Name = "labelRubSum";
            this.labelRubSum.Size = new System.Drawing.Size(50, 24);
            this.labelRubSum.TabIndex = 3;
            this.labelRubSum.Text = "руб.";
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTotalSum.Location = new System.Drawing.Point(26, 435);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(245, 25);
            this.labelTotalSum.TabIndex = 5;
            this.labelTotalSum.Text = "Общая сумма выручки:";
            // 
            // labelRubTotalSum
            // 
            this.labelRubTotalSum.AutoSize = true;
            this.labelRubTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRubTotalSum.Location = new System.Drawing.Point(463, 436);
            this.labelRubTotalSum.Name = "labelRubTotalSum";
            this.labelRubTotalSum.Size = new System.Drawing.Size(46, 24);
            this.labelRubTotalSum.TabIndex = 7;
            this.labelRubTotalSum.Text = "руб.";
            // 
            // textBoxTotalSum
            // 
            this.textBoxTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalSum.Location = new System.Drawing.Point(267, 433);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.ReadOnly = true;
            this.textBoxTotalSum.Size = new System.Drawing.Size(190, 29);
            this.textBoxTotalSum.TabIndex = 6;
            this.textBoxTotalSum.Text = "0";
            this.textBoxTotalSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 485);
            this.Controls.Add(this.labelRubTotalSum);
            this.Controls.Add(this.textBoxTotalSum);
            this.Controls.Add(this.labelTotalSum);
            this.Controls.Add(this.labelRubSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Автозаправка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.Label labelRUB1;
        private System.Windows.Forms.TextBox textBoxPriceOfFuel1;
        private System.Windows.Forms.Label labelPrice1;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.TextBox textBoxSumOrFuel;
        private System.Windows.Forms.Label labelRUB2;
        private System.Windows.Forms.Label labelLiters;
        private System.Windows.Forms.TextBox textBoxPriceOfFuel2;
        private System.Windows.Forms.RadioButton radioButtonSum;
        private System.Windows.Forms.TextBox textBoxQuantityOfFuel;
        private System.Windows.Forms.RadioButton radioButtonQuantity;
        private System.Windows.Forms.CheckBox checkBoxCocaCola;
        private System.Windows.Forms.CheckBox checkBoxCheeseburger;
        private System.Windows.Forms.CheckBox checkBoxHamburger;
        private System.Windows.Forms.CheckBox checkBoxHotDog;
        private System.Windows.Forms.TextBox textBoxSumOfCafe;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice2;
        private System.Windows.Forms.TextBox textBoxQuantityOfCocaCola;
        private System.Windows.Forms.TextBox textBoxQuantityOfCheeseburger;
        private System.Windows.Forms.TextBox textBoxQuantityOfHamburger;
        private System.Windows.Forms.TextBox textBoxQuantityOfHotDog;
        private System.Windows.Forms.Label labelRUB6;
        private System.Windows.Forms.Label labelRUB5;
        private System.Windows.Forms.Label labelRUB4;
        private System.Windows.Forms.Label labelRUB3;
        private System.Windows.Forms.TextBox textBoxPriceOfCocaCola;
        private System.Windows.Forms.TextBox textBoxPriceOfCheeseburger;
        private System.Windows.Forms.TextBox textBoxPriceOfHamburger;
        private System.Windows.Forms.TextBox textBoxPriceOfHotDog;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelRubSumOrFuel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelRubSumOfCafe;
        private System.Windows.Forms.Label labelRubSum;
        private System.Windows.Forms.Label labelTotalSum;
        private System.Windows.Forms.Label labelRubTotalSum;
        private System.Windows.Forms.TextBox textBoxTotalSum;






    }
}

