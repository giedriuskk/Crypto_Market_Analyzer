using CryptoCoinDataFromApi;
using Crypto_Analyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Crypto_Market_Analyzer_Tests
{
    public class TestProvider : ICryptoCoinProvider
    {
        public List<Coin> Coins;
        public List<CoinInfo> CoinInfo;
        public Info CoinsInfo;
        public string AverageChange;
        public List<Coin> GetCoins(string start)
        {
            return Coins;
        }
        public List<CoinInfo> GetAllCoinInfo(string Id)
        {
            return CoinInfo;
        }

        public Info GetTotalCoins()
        {
            return CoinsInfo;
        }

        public string AverageMarketChange(List<Coin> coins)
        {
            return AverageChange;
        }
    }
    [TestClass]
    public class UnitTest1
    {
        string start_test = "0";
        private TestProvider testProvider = new TestProvider
        {
            Coins = new List<Coin>
            {
                new Coin {Id="1", Name="BitCoin", PriceUsd="1000", PercentChange7d="2", PercentChange24="5", Rank="1", MarketCapUSD="2000"},
                new Coin {Id="2", Name="LiteCoin", PriceUsd="100", PercentChange7d="1", PercentChange24="3", Rank="2", MarketCapUSD="200"},
                new Coin {Id="3", Name="ZCash", PriceUsd="10", PercentChange7d="1", PercentChange24="1", Rank="3", MarketCapUSD="20"}
            }
        };
        [TestMethod]
        public void TestCoinRetrievalLocal()
        {
            var AccessProvider = new AccessProvider(testProvider);
            var coins1 = AccessProvider.GetCoins(start_test);
            Assert.AreEqual(3, coins1.Count);

            Assert.AreEqual(coins1, testProvider.Coins);
        }

        [TestMethod]
        public void TestAverageMarketChangeLocal()
        {
            Provider provider = new Provider();
            var coins = provider.AverageMarketChange(testProvider.Coins);
            Assert.AreEqual("3", coins);
        }


        [TestMethod]
        public void TestCoinRetrieval()
        {
            Provider provider = new Provider();
            var coins = provider.GetCoins(start_test);
            Assert.AreEqual(100, coins.Count);

        }

        [TestMethod]
        public void TestTotalCoinRetrieval()
        {
            Provider provider = new Provider();
            var total_coins = provider.GetTotalCoins();
            Assert.AreEqual(5479, total_coins.coins_num);

        }

        [TestMethod]
        public void TestAllCoinInfoRetrieval()
        {
            Provider provider = new Provider();
            var CoinInfo = provider.GetAllCoinInfo("90");
            foreach (var r in CoinInfo)
                Assert.AreEqual("Bitcoin", r.Name);

        }

    }
}
