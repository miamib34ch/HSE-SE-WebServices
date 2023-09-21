using System;
using System.Data;
using System.Windows.Forms;
using Use_Service.ServiceFahrenheitToCelsius;
using Use_Service.ServiceBank;

namespace Use_Service
{
    public partial class Form1 : Form
    {
        private const string zero = "0";
        ServiceClient OurService = new ServiceClient();
        DailyInfoSoapClient BankService = new DailyInfoSoapClient();
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            label3.Text = "";
            DataSet dataSet = BankService.GetCursOnDate(DateTime.Today);
            DataTable dataTable = dataSet.Tables["ValuteCursOnDate"];
            foreach (DataRow row in dataTable.Rows)
                if ($"{row["Vname"]}".Contains("Доллар США") || $"{row["Vname"]}".Contains("Евро"))
                    label3.Text += $"{row["Vnom"]} {row["Vname"].ToString().Trim()} = {row["Vcurs"]}₽\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double w))
            {
                if (textBox1.Text == "" || textBox1.Text == " ")
                    textBox1.Text = zero;
                label2.Text = $"Из фаренгейт в цельсии: {OurService.FahrenheitToCelsius(double.Parse(textBox1.Text))}";
            }
            else
            {
                MessageBox.Show("Вы ввели не число!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double w))
            {
                if (textBox1.Text == "" || textBox1.Text == " ")
                    textBox1.Text = zero;
                label2.Text = $"Из цельсий в фаренгейты: {OurService.CelsiusToFahrenheit(double.Parse(textBox1.Text))}";
            }
            else
            {
                MessageBox.Show("Вы ввели не число!");
            }
        }
    }
}
