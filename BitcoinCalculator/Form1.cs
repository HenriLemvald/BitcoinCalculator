using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BitcoinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nupuke_Click(object sender, EventArgs e)
        {

            if (CurrencyBox.SelectedItem.ToString() == "EUR")
            {
                resultlabel.Visible = true;
                Result.Visible = true;

                BitcionRates resultRates = GetRates();
                int userCoins = Int32.Parse(AmountOfBitcoins.Text);
                float currentRate = resultRates.bpi.EUR.Rate_float;
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.EUR.code}";
            }
            if (CurrencyBox.SelectedItem.ToString() == "USD")
            {
                resultlabel.Visible = true;
                Result.Visible = true;

                BitcionRates resultRates = GetRates();
                int userCoins = Int32.Parse(AmountOfBitcoins.Text);
                float currentRate = resultRates.bpi.USD.Rate_float;
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.USD.code}";
            }
            if (CurrencyBox.SelectedItem.ToString() == "GBP")
            {
                resultlabel.Visible = true;
                Result.Visible = true;

                BitcionRates resultRates = GetRates();
                int userCoins = Int32.Parse(AmountOfBitcoins.Text);
                float currentRate = resultRates.bpi.GBP.Rate_float;
                float btcResult = userCoins * currentRate;
                Result.Text = $"{btcResult} {resultRates.bpi.GBP.code}";
            }

        }

        public static BitcionRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "Get";

            BitcionRates bitcoin;

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using(var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcionRates>(response);
            }

            return bitcoin;
        }

        private void CurrencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
