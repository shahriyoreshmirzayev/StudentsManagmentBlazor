using StudentsManagment.Shared.Models;

namespace StudentsManagment.Client.StudentRepository
{
    public interface ICountryRepository
    {
        Task<Country> AddAsync(Country mod);
        Task<Country> UpdateAsync(Country mod);
        Task<Country> DeleteAsync(int id);
        Task<List<Country>> GetAllAsync();
        Task<Country> GetByIdAsync(int id);
    }
}
