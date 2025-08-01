using StudentsManagment.Shared.Models;

namespace StudentsManagment.Client.StudentRepository;

public interface ISystemCodeRepository
{
    Task<SystemCode> AddAsync(SystemCode mod);
    Task<SystemCode> UpdateAsync(SystemCode mod);
    Task<SystemCode> DeleteAsync(int id);
    Task<List<SystemCode>> GetAllAsync();
    Task<SystemCode> GetByIdAsync(int id);
}
