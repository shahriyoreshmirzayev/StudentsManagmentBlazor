using StudentsManagment.Client.StudentRepository;
using StudentsManagment.Shared.Models;
using System.Net.Http.Json;

namespace StudentsManagment.Client.Services
{
    public class SystemCodeService : ISystemCodeRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://yourapiurl/api/SystemCodes";
        public SystemCodeService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<SystemCode>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/All-SystemCodes");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<SystemCode>>();
            }
            return null;
        }
        public async Task<SystemCode> AddAsync(SystemCode mod)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_baseUrl}/Add-SystemCode", mod);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<SystemCode>();
            }
            return null;
        }
        public async Task<SystemCode> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseUrl}/Delete-SystemCode/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<SystemCode>();
            }
            return null;
        }
        public async Task<SystemCode> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/Single-SystemCode/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<SystemCode>();
            }
            return null;
        }
        public async Task<SystemCode> UpdateAsync(SystemCode mod)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}/Update-SystemCode/{mod.Id}", mod);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<SystemCode>();
            }
            return null;
        }
    }
}

