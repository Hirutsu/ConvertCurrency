using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public double DollarToRub = 57.5;
        public double DollarToEuro = 0.96;

        public double RubToDollar = 0.017;
        public double RubToEuro = 0.0175;

        public double EuroToRub = 59.85;
        public double EuroToDollar = 1.04;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(inputTB.Text);
            double resultValue = i;

            if (fromCB.SelectedItem == "Dollar" && ToCB.SelectedItem == "Rub")
            {
                resultValue = DollarToRub * i;
            }
            if (fromCB.SelectedItem == "Dollar" && ToCB.SelectedItem == "Euro")
            {
                resultValue = DollarToEuro * i;
            }

            if (fromCB.SelectedItem == "Rub" && ToCB.SelectedItem == "Dollar")
            {
                resultValue = RubToDollar * i;
            }
            if (fromCB.SelectedItem == "Rub" && ToCB.SelectedItem == "Euro")
            {
                resultValue = RubToEuro * i;
            }

            if (fromCB.SelectedItem == "Euro" && ToCB.SelectedItem == "Dollar")
            {
                resultValue = EuroToDollar * i;
            }
            if (fromCB.SelectedItem == "Euro" && ToCB.SelectedItem == "Rub")
            {
                resultValue = EuroToRub * i;
            }

            resultTB.Text = resultValue.ToString();
        }
    }
}
