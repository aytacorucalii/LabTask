using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceeTaskk.Models
{
    internal class StudentService : IStudentService
    {
        private Student[] students = new Student[15];
        private int currentIndex = 0;
        public void AddStudent(Student student)
        {
            if (currentIndex < students.Length)
            {
                students[currentIndex] = student;
                currentIndex++;
            }
            else
            {
                Console.WriteLine("Massiv doludur, əlavə tələbə yer yoxdur.");
            }
        }

        public Student[] GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student[] GetStudentByName()
        {
            throw new NotImplementedException();
        }

        public void removeStudent(int id, bool isSoftDelete)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
