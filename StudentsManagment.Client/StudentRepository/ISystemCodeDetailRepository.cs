using StudentsManagment.Shared.Models;

namespace StudentsManagment.Client.StudentRepository;

public interface ISystemCodeDetailRepository
{
    Task<SystemCodeDetail> AddAsync(SystemCodeDetail mod);
    Task<SystemCodeDetail> UpdateAsync(SystemCodeDetail mod);
    Task<SystemCodeDetail> DeleteAsync(int id);
    Task<List<SystemCodeDetail>> GetAllAsync();
    Task<SystemCodeDetail> GetByIdAsync(int id);
    Task<List<SystemCodeDetail>> GetByCodeAsync(string code);
}
