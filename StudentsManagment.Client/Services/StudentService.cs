using StudentsManagment.Shared.Models;
using StudentsManagment.Shared.StudentRepository;
using System.Net.Http.Json;

namespace StudentsManagment.Client.Services
{
    public class StudentService : IStudentRepository
    {
        private readonly HttpClient _httpClient;
        public StudentService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<Student> AddStudentAsync(Student student)
        {
            var newstudent = await _httpClient.PostAsJsonAsync<Student>("api/Student/Add-Student", student);
            var response = await newstudent.Content.ReadFromJsonAsync<Student>();
            return response;
        }

        public async Task<Student> DeleteStudentAsync(int studentId)
        {
            var student = await _httpClient.DeleteAsync("api/Student/DeleteStudent/" + studentId);
            var response = await student.Content.ReadFromJsonAsync<Student>();
            return response;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var allstudents = await _httpClient.GetAsync("api/Student/All-Students");
            var response = await allstudents.Content.ReadFromJsonAsync<List<Student>>();
            return response;
        }

        public async Task<Student> GetStudentByIdAsync(int studentId)
        {
            var singlestudent = await _httpClient.GetAsync("api/Student/Single-Student/" + studentId); // shu yerda xatolik bo'lishi mumkin
            var response = await singlestudent.Content.ReadFromJsonAsync<Student>();
            return response;
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            var newstudent = await _httpClient.PostAsJsonAsync<Student>("api/Student/Update-Student", student);
            var response = await newstudent.Content.ReadFromJsonAsync<Student>();
            return response;
        }
    }
}
