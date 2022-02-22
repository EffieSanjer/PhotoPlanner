using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PhotoSS
{
    class PeopleService
    {
        const string Url = "http://localhost:8202/api/People/"; // обращайте внимание на конечный слеш
        // настройки для десериализации для нечувствительности к регистру символов
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        // настройка клиента
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        // получаем всех
        public async Task<IEnumerable<People>> GetPeople()
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonSerializer.Deserialize<IEnumerable<People>>(result, options);
        }

    }
    class LocationService
    {
        const string Url = "http://localhost:8202/api/Location/"; // обращайте внимание на конечный слеш
        // настройки для десериализации для нечувствительности к регистру символов
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        // настройка клиента
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        // получаем всех
        public async Task<IEnumerable<Location>> GetLocations()
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonSerializer.Deserialize<IEnumerable<Location>>(result, options);
        }

    }
    class PhotoService
    {
        const string Url = "http://localhost:8202/api/Photoshoot/"; // обращайте внимание на конечный слеш
        // настройки для десериализации для нечувствительности к регистру символов
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        // настройка клиента
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        // получаем всех
        public async Task<IEnumerable<Photoshoot>> GetPhotoshoots()
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonSerializer.Deserialize<IEnumerable<Photoshoot>>(result, options);
        }

    }
    class FinanceService
    {
        const string Url = "http://localhost:8202/api/Finance/"; // обращайте внимание на конечный слеш
        // настройки для десериализации для нечувствительности к регистру символов
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        // настройка клиента
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        // получаем всех
        public async Task<IEnumerable<Finances>> GetFinances()
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonSerializer.Deserialize<IEnumerable<Finances>>(result, options);
        }

    }
}
