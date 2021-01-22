using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CryptoCoinDataFromApi
{
    public interface ICryptoCoinProvider
    {
        List<Coin> GetCoins(string start);
        Info GetTotalCoins();
        List<CoinInfo> GetAllCoinInfo(string id);
        string AverageMarketChange(List<Coin> coins);
    }

    public class Root
    {
        public List<Coin> data { get; set; }
        public Info info { get; set; }
    }
    public class Provider : ICryptoCoinProvider
    {
        public List<Coin> GetCoins(string start)
        {
            using (HttpClient client = new HttpClient())
            {
                bool success = Int32.TryParse(start, out int val);
                client.BaseAddress = new Uri("https://api.coinlore.net/api/tickers/");
                string s;
                if (success)
                {
                    
                    s = client.GetStringAsync("?start=" + start + "&limit=100").Result;
                }
                else
                {
                    s = client.GetStringAsync("?start=0&limit=100").Result;
                    
                }
                var list = JsonConvert.DeserializeObject<Root>(s);
                return list.data;

            }
        }

        public Info GetTotalCoins()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.coinlore.net/api/tickers/");
                string s = client.GetStringAsync("").Result;
                var result = JsonConvert.DeserializeObject<Root>(s);
                return result.info;
            }
        }

        public List<CoinInfo> GetAllCoinInfo(string coinId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.coinlore.net/api/ticker/?id=" + coinId);
                string s = client.GetStringAsync("").Result;
                var result = JsonConvert.DeserializeObject <List<CoinInfo>>(s);
                return result;
            }
        }

        public string AverageMarketChange(List<Coin> coins)
        {
            double avgPercent = 0;

            foreach (var r in coins)
            {
                avgPercent += float.Parse(r.PercentChange24);
            }
            avgPercent = Math.Round((avgPercent / coins.Count), 2);

            return avgPercent.ToString();
        }

    }

    public class AccessProvider : ICryptoCoinProvider
    {
        private readonly ICryptoCoinProvider I;
        private Info coinsInfo = null;
        private List<Coin> coins = null;
        private List<CoinInfo> allCoinInfo = null;
        public AccessProvider(ICryptoCoinProvider provider)
        {
            I = provider;
        }
        public List<Coin> GetCoins(string start)
        {
            if (coins != null)
                if(String.Equals(coins[0].Id, start))
                    return coins;
         
            return coins = I.GetCoins(start);
        }


        public string AverageMarketChange(List<Coin> coins)
        {
            
           return I.AverageMarketChange(coins);
        }

        public List<CoinInfo> GetAllCoinInfo(string Id)
        {
            if (allCoinInfo != null)
                return allCoinInfo;
            return allCoinInfo = I.GetAllCoinInfo(Id);
        }

        public Info GetTotalCoins()
        {
            if (coinsInfo != null)
                return coinsInfo;
            return coinsInfo = I.GetTotalCoins();
        }


    }
 

    public class Coin
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }        
        [JsonProperty("price_usd")]
        public string PriceUsd { get; set; }
        [JsonProperty("percent_change_7d")]
        public string PercentChange7d { get; set; }
        [JsonProperty("percent_change_24h")]
        public string PercentChange24 { get; set; }
        [JsonProperty("rank")]
        public string Rank { get; set; }
        [JsonProperty("market_cap_usd")]
        public string MarketCapUSD { get; set; }

    }

    public class CoinInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("nameid")]
        public string NameId { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
        [JsonProperty("price_usd")]
        public string PriceUsd { get; set; }
        [JsonProperty("percent_change_24h")]
        public string PC24h { get; set; }
        [JsonProperty("percent_change_7d")]
        public string PC7d { get; set; }
        [JsonProperty("market_cap_usd")]
        public string MarketCapUsd { get; set; }
        [JsonProperty("volume24")]
        public string Volume24 { get; set; }
        [JsonProperty("csupply")]
        public string CS { get; set; }
        [JsonProperty("price_btc")]
        public string PBtc { get; set; }
        [JsonProperty("tsupply")]
        public string TS { get; set; }
        [JsonProperty("msupply")]
        public string MS { get; set; }
    }

    public class Info
    {
        public int coins_num { get; set; }
        public int time { get; set; }
    }
}
