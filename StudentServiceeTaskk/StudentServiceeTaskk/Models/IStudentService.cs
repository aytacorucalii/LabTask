using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceeTaskk.Models
{
    internal interface IStudentService
    {
        Student GetStudent(int id);
        Student[] GetAllStudents();
        Student[] GetStudentByName();
         void AddStudent(Student student);    
         void UpdateStudent(int id);
         void removeStudent(int id, bool isSoftDelete);
    }
}
