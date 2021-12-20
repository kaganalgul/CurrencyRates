using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CurrencyRatesModel.Models;
using CurrencyRatesModel.Helpers;

namespace CurrencyRatesModel
{
    public class CurrencyFactory
    {
        private HttpClient _client;

        //Singleton
        private static CurrencyFactory _currencyFactory;

        private CurrencyFactory()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://free.currconv.com");
        }

        public static CurrencyFactory GetFactory()
        {
            if (_currencyFactory is null)
            {
                _currencyFactory = new CurrencyFactory();
            }

            return _currencyFactory;
        }
        //

        public async Task<Currency> GetCurrenciesRecordingToTime(string mainCurrency, string targetCurrency, DateTime dateTime)
        {            
            string urlTime = dateTime.GetSuitableTimeForUrl();

            HttpResponseMessage response = await _client.GetAsync($"/api/v7/convert?q={mainCurrency}_{targetCurrency}&compact=ultra&date={urlTime}&apiKey=db091a621016f05980d9");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }

            string readTask = await response.Content.ReadAsStringAsync();

            Currency c = JsonConvert.DeserializeObject<Currency>(readTask);

            return c;
        }
    }
}
