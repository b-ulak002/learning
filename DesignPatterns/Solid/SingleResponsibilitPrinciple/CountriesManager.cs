using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Solid.SingleResponsibilitPrinciple
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


        private async Task GetAll()
        {
            HttpResponseMessage response = await _http.GetAsync("https://restcountries.eu/rest/v2/all");     

            if (ErrorHandler.HandleResponse(response.StatusCode))
            {
                var content = await response.Content.ReadAsStringAsync();
                _countries = JsonConvert.DeserializeObject<Country[]>(content);
            }
        }
    }
}