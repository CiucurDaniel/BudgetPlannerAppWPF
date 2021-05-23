using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace BudgetPlanner.Services
{
    class CurrencyConverterService
    {
        private readonly String BASE_URI = "https://free.currconv.com";
        private readonly String API_VERSION = "v7";

        private readonly String API_KEY = "c36181178f580f8cba07";


        public CurrencyConverterService() { }

        public Decimal GetCurrencyExchange(String localCurrency, String foreignCurrency)
        {
            var code = $"{localCurrency}_{foreignCurrency}";
            var newRate = FetchSerializedData(code);
            return newRate;
        }

        private Decimal FetchSerializedData(String code)
        {
            var url = $"{BASE_URI}/api/{API_VERSION}/convert?q={code}&compact=ultra";
            var webClient = new WebClient();
            var jsonData = String.Empty;

            var conversionRate = 1.0m;
            try
            {
                // get the JSON as a string
                jsonData = webClient.DownloadString(url);

                // deserialize into JSON 
                var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(jsonData);


                // get the conversion rate
                conversionRate = jsonObject[code];


            }
            catch (Exception) { }

            return conversionRate;
        }
    }
}
