using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(string id);
        Task<Student> Add(Student student);
        Task<Student> Update( string id, Student student);
        Task Delete(string id);
    }
}