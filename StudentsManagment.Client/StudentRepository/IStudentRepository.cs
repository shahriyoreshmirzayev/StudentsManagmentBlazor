﻿using StudentsManagment.Shared.Models;

namespace StudentsManagment.Shared.StudentRepository
{
    public interface IStudentRepository
    {
        Task<Student> AddStudentAsync(Student student);

        Task<Student> UpdateStudentAsync(Student student);

        Task<Student> DeleteStudentAsync(int studentId);

        Task<List<Student>> GetAllStudentsAsync();

        Task<Student> GetStudentByIdAsync(int studentId);
    }
}
