using System.Net.Http;
using System.Threading.Tasks;

namespace SkillSnap.Client.Services
{
    public class AuthService
    {
        private readonly HttpClient _http;
        public AuthService(HttpClient http) => _http = http;

        public async Task<bool> Login(string username, string password)
        {
            // Implement login logic
            return true;
        }
    }
}