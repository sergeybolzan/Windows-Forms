using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BestOil
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Fuel> fuels = new List<Fuel>() { 
            new Fuel(){Name = "АИ-92", Price = 1.12M},
            new Fuel(){Name = "АИ-95", Price = 1.20M},
            new Fuel(){Name = "АИ-98", Price = 1.30M},
            new Fuel(){Name = "ДТ", Price = 1.24M},
            };
            comboBoxFuel.DataSource = fuels;
            comboBoxFuel.DisplayMember = "Name";
        }
        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSumOrFuel.Clear();
            Fuel selFuel = (Fuel)comboBoxFuel.SelectedItem;
            textBoxPriceOfFuel1.Text = selFuel.Price.ToString();
        }

        private void radioButtonQuantity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxQuantityOfFuel.Enabled = true;
            textBoxPriceOfFuel2.Enabled = false;
            groupBox4.Text = "К оплате:";
            labelSumOrFuel.Text = "руб.";
            textBoxSumOrFuel.Clear();
        }

        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            textBoxQuantityOfFuel.Enabled = false;
            textBoxPriceOfFuel2.Enabled = true;
            groupBox4.Text = "К выдаче:";
            labelSumOrFuel.Text = "л.";
            textBoxSumOrFuel.Clear();

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (radioButtonQuantity.Checked)
            {
                if (!(Regex.Match(textBoxQuantityOfFuel.Text, @"\d{1,5}(\,\d{0,2})?").Value == textBoxQuantityOfFuel.Text) || String.IsNullOrEmpty(textBoxQuantityOfFuel.Text))
                {
                    //MessageBox.Show("неправильно");
                    int durationMilliseconds = 2000;
                    toolTip1.Show("Введено неверное значение", textBoxQuantityOfFuel, durationMilliseconds);
                    return;
                }
                else textBoxSumOrFuel.Text = Math.Round((Decimal.Parse(textBoxPriceOfFuel1.Text) * Decimal.Parse(textBoxQuantityOfFuel.Text)), 2, MidpointRounding.AwayFromZero).ToString();
            }
            if (radioButtonSum.Checked)
            {
                if (!(Regex.Match(textBoxPriceOfFuel2.Text, @"\d{1,5}(\,\d{0,2})?").Value == textBoxPriceOfFuel2.Text) || String.IsNullOrEmpty(textBoxPriceOfFuel2.Text))
                {
                    //MessageBox.Show("неправильно");
                    int durationMilliseconds = 2000;
                    toolTip1.Show("Введено неверное значение", textBoxPriceOfFuel2, durationMilliseconds);
                    return;
                }
                else textBoxSumOrFuel.Text = Math.Round((Decimal.Parse(textBoxPriceOfFuel2.Text) / Decimal.Parse(textBoxPriceOfFuel1.Text)), 2, MidpointRounding.AwayFromZero).ToString();
            }
        }

        private void textBoxQuantityOfFuel_TextChanged(object sender, EventArgs e)
        {
            textBoxSumOrFuel.Clear();
        }
        private void textBoxPriceOfFuel2_TextChanged(object sender, EventArgs e)
        {
            textBoxSumOrFuel.Clear();
        }

        private void checkBoxHotDog_Click(object sender, EventArgs e)
        {
            double Summa = 0;
            if (checkBoxHotDog.Checked)
                if (!(Regex.Match(textBoxQuantityOfHotDog.Text, @"\d{1,5}").Value == textBoxQuantityOfHotDog.Text) || String.IsNullOrEmpty(textBoxQuantityOfHotDog.Text))
                {
                    //MessageBox.Show("неправильно");
                    int durationMilliseconds = 2000;
                    toolTip2.Show("Введено неверное значение", textBoxQuantityOfHotDog, durationMilliseconds);
                    return;
                }
                else Summa += Convert.ToDouble(textBoxPriceOfHotDog.Text) * Convert.ToDouble(textBoxQuantityOfHotDog.Text);
            if (checkBoxHamburger.Checked)
                Summa += Convert.ToDouble(textBoxPriceOfHamburger.Text) * Convert.ToDouble(textBoxQuantityOfHamburger.Text);
            if (checkBoxCheeseburger.Checked)
                Summa += Convert.ToDouble(textBoxPriceOfCheeseburger.Text) * Convert.ToDouble(textBoxQuantityOfCheeseburger.Text);
            if (checkBoxCocaCola.Checked)
                Summa += Convert.ToDouble(textBoxPriceOfCocaCola.Text) * Convert.ToDouble(textBoxQuantityOfCocaCola.Text);
            textBoxSumOfCafe.Text = Summa.ToString();
        }


    }

    class Fuel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

}
