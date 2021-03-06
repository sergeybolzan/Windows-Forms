﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Word = Microsoft.Office.Interop.Word;

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
        /// <summary>
        /// Действие при смене топлива.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSumOrFuel.Clear();
            Fuel selFuel = (Fuel)comboBoxFuel.SelectedItem;
            textBoxPriceOfFuel1.Text = selFuel.Price.ToString();
        }
        /// <summary>
        /// Дествие по нажатию на RadioButton "Количество". Делаем нективным ввод суммы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonQuantity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxQuantityOfFuel.Enabled = true;
            textBoxPriceOfFuel2.Enabled = false;
            groupBox4.Text = "К оплате:";
            labelRubSumOrFuel.Text = "руб.";
            textBoxSumOrFuel.Text = "0";
            textBoxSum.Text = "0";
        }
        /// <summary>
        /// Дествие по нажатию на RadioButton "Сумма". Делаем нективным ввод количества.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            textBoxQuantityOfFuel.Enabled = false;
            textBoxPriceOfFuel2.Enabled = true;
            groupBox4.Text = "К выдаче:";
            labelRubSumOrFuel.Text = "л.";
            textBoxSumOrFuel.Text = "0";
            textBoxSum.Text = "0";
        }
        /// <summary>
        /// Действие по нажатию на кнопку "Рассчитать". В зависимоти от выбранной радиокнопки, проверяем соответствующий
        /// текстбокс на допустимый текст (число с максимум двумя знаками после запятой). Если текст недопустим, то выходим
        /// из обработчика. Если текст допустим, то подсчитываем значение, округляем до двух знаков после запятой и выводим в текстбоксы "К оплате" и "Итого".
        /// А далее подсчитываем выручку за сеанс и сохраняем чек в документ Word.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (radioButtonQuantity.Checked)
            {
                if (Regex.Match(textBoxQuantityOfFuel.Text, @"\d{1,5}(\,\d{0,2})?").Value != textBoxQuantityOfFuel.Text || String.IsNullOrEmpty(textBoxQuantityOfFuel.Text))
                {
                    int durationMilliseconds = 2000;
                    toolTip1.Show("Введено недопустимое значение", textBoxQuantityOfFuel, durationMilliseconds);
                    return;
                }
                else
                {
                    textBoxSumOrFuel.Text = Math.Round((Decimal.Parse(textBoxPriceOfFuel1.Text) * Decimal.Parse(textBoxQuantityOfFuel.Text)), 2, MidpointRounding.AwayFromZero).ToString();
                    textBoxSum.Text = (Decimal.Parse(textBoxSumOrFuel.Text) + Decimal.Parse(textBoxSumOfCafe.Text)).ToString();
                }
            }
            if (radioButtonSum.Checked)
            {
                if (Regex.Match(textBoxPriceOfFuel2.Text, @"\d{1,5}(\,\d{0,2})?").Value != textBoxPriceOfFuel2.Text || String.IsNullOrEmpty(textBoxPriceOfFuel2.Text))
                {
                    int durationMilliseconds = 2000;
                    toolTip1.Show("Введено недопустимое значение", textBoxPriceOfFuel2, durationMilliseconds);
                    return;
                }
                else
                {
                    textBoxSumOrFuel.Text = Math.Round((Decimal.Parse(textBoxPriceOfFuel2.Text) / Decimal.Parse(textBoxPriceOfFuel1.Text)), 2, MidpointRounding.AwayFromZero).ToString();
                    textBoxSum.Text = (Decimal.Parse(textBoxPriceOfFuel2.Text) + Decimal.Parse(textBoxSumOfCafe.Text)).ToString();
                }
            }
            textBoxTotalSum.Text = (Decimal.Parse(textBoxTotalSum.Text) + Decimal.Parse(textBoxSum.Text)).ToString();
            SaveToDocx();
        }
        /// <summary>
        /// При изменении текста в текстбоксе "Количество литров" обнуляем высчитываемые результаты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxQuantityOfFuel_TextChanged(object sender, EventArgs e)
        {
            textBoxSumOrFuel.Text = "0";
            textBoxSum.Text = "0";
        }
        /// <summary>
        /// При изменении текста в текстбоксе "Сумма" обнуляем высчитываемые результаты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPriceOfFuel2_TextChanged(object sender, EventArgs e)
        {
            textBoxSumOrFuel.Text = "0";
            textBoxSum.Text = "0";
        }
        /// <summary>
        /// Действие при установке "галочки" в чекбоксах и изменении текста в текстбоксах "Количество" в групбоксе "Мини-кафе".
        /// Подсчитывается сумма и выводится в текстбокс "К оплате". Если введен нечисловой символ, то выводимые суммы обнуляются.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxHotDog_Click(object sender, EventArgs e)
        {
            int a;
            bool IsCorrectInput = true;
            double Summa = 0;
            if (checkBoxHotDog.Checked)
            {
                if (Int32.TryParse(textBoxQuantityOfHotDog.Text, out a))
                    Summa += Convert.ToDouble(textBoxPriceOfHotDog.Text) * Convert.ToDouble(textBoxQuantityOfHotDog.Text);
                else IsCorrectInput = false;
            }
            if (checkBoxHamburger.Checked)
            {
                if (Int32.TryParse(textBoxQuantityOfHamburger.Text, out a))
                    Summa += Convert.ToDouble(textBoxPriceOfHamburger.Text) * Convert.ToDouble(textBoxQuantityOfHamburger.Text);
                else IsCorrectInput = false;
            }
            if (checkBoxCheeseburger.Checked)
            {
                if (Int32.TryParse(textBoxQuantityOfCheeseburger.Text, out a))
                    Summa += Convert.ToDouble(textBoxPriceOfCheeseburger.Text) * Convert.ToDouble(textBoxQuantityOfCheeseburger.Text);
                else IsCorrectInput = false;
            }
            if (checkBoxCocaCola.Checked)
            {
                if (Int32.TryParse(textBoxQuantityOfCocaCola.Text, out a))
                    Summa += Convert.ToDouble(textBoxPriceOfCocaCola.Text) * Convert.ToDouble(textBoxQuantityOfCocaCola.Text);
                else IsCorrectInput = false;
            }
            if (IsCorrectInput == true) textBoxSumOfCafe.Text = Summa.ToString();
            else
            {
                textBoxSumOfCafe.Text = "0";
                textBoxSum.Text = "0";
            }
        }
        /// <summary>
        /// Открываем документ Word "Checks.docx", лежащий рядом с "exe". Выводим в него дату, купленное топливо, продукты,
        /// итоговую сумму и сохраняем документ.
        /// </summary>
        private void SaveToDocx()
        {
            Word.Application wordapp = new Word.Application();
            Word.Document doc = new Word.Document();
            try
            {
                doc = wordapp.Documents.Open(System.Environment.CurrentDirectory + @"\Checks.docx");
                //doc = wordapp.Documents.Add();

                Word.Paragraph paragraph = doc.Content.Paragraphs.Add();
                paragraph.Range.Text = System.DateTime.Now.ToString();
                paragraph.Range.InsertParagraphAfter();
                if (radioButtonQuantity.Checked && textBoxQuantityOfFuel.Text != "0") paragraph.Range.Text = "- " + comboBoxFuel.Text + " " + textBoxQuantityOfFuel.Text + " л. - " + textBoxSumOrFuel.Text + " руб.\n";
                if (radioButtonSum.Checked && textBoxPriceOfFuel2.Text != "0") paragraph.Range.Text = "- " + comboBoxFuel.Text + " " + textBoxSumOrFuel.Text + " л. - " + textBoxPriceOfFuel2.Text + " руб.\n";
                if (textBoxSumOfCafe.Text != "0")
                {
                    if (checkBoxHotDog.Checked) paragraph.Range.Text = "- " + checkBoxHotDog.Text + " - " + textBoxQuantityOfHotDog.Text + " шт. - " + Convert.ToDouble(textBoxPriceOfHotDog.Text) * Convert.ToDouble(textBoxQuantityOfHotDog.Text) + " руб.\n";
                    if (checkBoxHamburger.Checked) paragraph.Range.Text = "- " + checkBoxHamburger.Text + " - " + textBoxQuantityOfHamburger.Text + " шт. - " + Convert.ToDouble(textBoxPriceOfHamburger.Text) * Convert.ToDouble(textBoxQuantityOfHamburger.Text) +" руб.\n";
                    if (checkBoxCheeseburger.Checked) paragraph.Range.Text = "- " + checkBoxCheeseburger.Text + " - " + textBoxQuantityOfCheeseburger.Text + " шт. - " + Convert.ToDouble(textBoxPriceOfCheeseburger.Text) * Convert.ToDouble(textBoxQuantityOfCheeseburger.Text) +" руб.\n";
                    if (checkBoxCocaCola.Checked) paragraph.Range.Text = "- " + checkBoxCocaCola.Text + " - " + textBoxQuantityOfCocaCola.Text + " шт. - " + Convert.ToDouble(textBoxPriceOfCocaCola.Text) * Convert.ToDouble(textBoxQuantityOfCocaCola.Text) + " руб.\n";
                }
                paragraph.Range.Text = "Итого: " + textBoxSum.Text + " руб.\n\n";

                //doc.SaveAs2(System.Environment.CurrentDirectory + @"\Checks");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                    ((Word._Document)doc).Close(); // без приведения типов выскакивает предупреждение
                    ((Word._Application)wordapp).Quit(); // без приведения типов выскакивает предупреждение
            }
        }
    }

    class Fuel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

}
