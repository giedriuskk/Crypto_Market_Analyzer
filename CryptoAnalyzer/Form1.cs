using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using CryptoCoinDataFromApi;

namespace Crypto_Analyzer
{
    public partial class Form1 : Form
    {
        private AccessProvider I = new AccessProvider(new Provider());
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            var result = I.GetTotalCoins();
            label6.Text= result.coins_num.ToString();
            label6.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            
            var result = I.GetCoins(textBox1.Text);
            foreach(var coin in result)
            {
                
                    var item = new ListViewItem(new[] { coin.Name, coin.PriceUsd, coin.PercentChange24, coin.PercentChange7d, coin.Rank, coin.MarketCapUSD });
                    item.Tag = coin;
                    listView1.Items.Add(item);

            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null && listView1.SelectedItems.Count != 0)
            {
              
                var selected = listView1.FocusedItem.Text;
                var result = I.GetCoins(textBox1.Text);
                var r= result.Find(x => x.Name.Contains(selected));
                var CoinID = r.Id;
                Form2 coinInfo = new Form2();

                coinInfo.CoinID = CoinID;
                coinInfo.ShowDialog();

                /*
                foreach (var r in result)
                {
                    if ((r.Name).Equals(selected))
                    { var CoinID = r.Id;

                      Form2 coinInfo = new Form2();

                      coinInfo.CoinID = CoinID;
                      coinInfo.ShowDialog();

                    }

                }
                */
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var result = I.GetCoins(textBox1.Text);
            foreach (var coin in result)
            {
                if (float.Parse(numericUpDown1.Text) <= float.Parse(coin.PercentChange24) && float.Parse(numericUpDown2.Text) >= float.Parse(coin.PercentChange24))
                {
                    var item = new ListViewItem(new[] { coin.Name, coin.PriceUsd, coin.PercentChange24, coin.PercentChange7d, coin.Rank, coin.MarketCapUSD });
                    item.Tag = coin;
                    listView1.Items.Add(item);
                }

            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            List<Coin> coins = I.GetCoins(textBox1.Text);
            var result = I.AverageMarketChange(coins);
            ListViewItem item = new ListViewItem();
            listView2.Items.Add(result + " %");
        }

    }
}
