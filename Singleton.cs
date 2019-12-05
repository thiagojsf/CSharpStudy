using System.Net.Http;

namespace HeyOh
{
    public class Singleton
    {
        private static HttpClient _httpClient;
        public static HttpClient HttpClientSingleton
        {
            get
            {
                if (_httpClient == null)
                    _httpClient = new HttpClient();
                return _httpClient;
            }
        }
    }
}
