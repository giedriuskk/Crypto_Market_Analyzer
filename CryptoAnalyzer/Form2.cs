using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoCoinDataFromApi;

namespace Crypto_Analyzer
{
    public partial class Form2 : Form
    {
        private AccessProvider I = new AccessProvider(new Provider());

        public string CoinID { get; set; }

        public Form2()
        {
            InitializeComponent();
            Load += new EventHandler(Form2_Load);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            var CoinInfo = I.GetAllCoinInfo(CoinID);
            Console.WriteLine(CoinInfo);

            foreach (var Coin in CoinInfo)
            {
                var item = new ListViewItem(new[] { Coin.Name, Coin.Symbol, Coin.Rank.ToString(), Coin.PriceUsd, Coin.PC24h, Coin.PC7d, Coin.MarketCapUsd, Coin.Volume24, Coin.CS, Coin.PBtc, Coin.TS, Coin.MS });
                item.Tag = Coin;
                listView1.Items.Add(item);
            }
           

        }
    }
}
