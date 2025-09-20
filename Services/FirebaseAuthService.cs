using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace RegisterLogin.Services
{
    public class FirebaseAuthService
    {
        private readonly HttpClient _http; 
        private readonly string _apiKey;

        public FirebaseAuthService(HttpClient http, string apiKey)
        {
            _http = http;
            _apiKey = apiKey;
        }

        public async Task<string> SignUpAsync(string email, string password)
        {
            var payload = new
            {
                email,
                password,
                returnSecureToken = true
            };

            var response = await _http.PostAsJsonAsync(
                $"https://identitytoolkit.googleapis.com/v1/accounts:signUp?key={_apiKey}",
                payload);

            response.EnsureSuccessStatusCode();

            using var doc = await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
            return doc.RootElement.GetProperty("idToken").GetString(); // JWT for later
        }
    }
}
