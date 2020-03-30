using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Solid.NoSRP
{
    public class CountriesManager
    {
        private HttpClient _http;
        private Country[] _countries;

        public CountriesManager()
        {
            _http = new HttpClient();
        }

        public async Task<Country[]> GetCountries()
        {
            if (_countries != null)
            {
                return _countries;
            }
            else
            {
                await GetAll();
                return _countries;
            }
        }


        /// <summary>
        ///This is the get all function. Notice something weird about it. Exactly. We are checking for the status code in a function that is supposed to return a list of           
        ///countries. So, this is a violation of the single responsibility principle. The get all function should only be responsible for creating thecountries API and getting a   
        ///list of countries back
        /// </summary>
        /// <returns></returns>
        private async Task GetAll()
        {
            HttpResponseMessage response = await _http.GetAsync("https://restcountries.eu/rest/v2/all");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                _countries = JsonConvert.DeserializeObject<Country[]>(content);
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                Console.WriteLine("Countries API is momentarily unavailable");
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                Console.WriteLine("Countries API encountered an error, please try again");
            }
            else
            {
                Console.WriteLine("An eror has occured while fetching the countries");
            }
        }
    }        
}
