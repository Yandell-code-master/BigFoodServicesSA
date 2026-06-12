using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AplicacionEscritorio.Services
{
    public static class ApiService
    {
        private static readonly HttpClient _client = new HttpClient();

        public static string BaseUrl { get; set; } = "http://BigFOOD-API.somee.com";
        public static string Token { get; private set; }
        public static string UsuarioActual { get; set; }

        public static async Task<bool> LoginAsync(string email, string password)
        {
            try
            {
                _client.DefaultRequestHeaders.Authorization = null;

                var payload = new { email, password };
                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync(
                    "http://Api-security.somee.com/login", content);

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<dynamic>(
                        await response.Content.ReadAsStringAsync());
                    Token = result.token;
                    UsuarioActual = email;
                    _client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", Token);
                    return true;
                }
            }
            catch { }
            return false;
        }

        public static async Task<T> GetAsync<T>(string endpoint)
        {
            var response = await _client.GetAsync($"{BaseUrl}/{endpoint}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static async Task<string> PostAsync(string endpoint, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{BaseUrl}/{endpoint}", content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> PutAsync(string endpoint, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{BaseUrl}/{endpoint}", content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> DeleteAsync(string endpoint)
        {
            var response = await _client.DeleteAsync($"{BaseUrl}/{endpoint}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
