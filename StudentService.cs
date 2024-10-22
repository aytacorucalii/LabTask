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
        private int studentCount = 0;
        

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
            Student[] result = new Student[studentCount];

            for (int i = 0; i < studentCount; i++) 
            {
                result[i] = students[i]; 
            }

            return result;
        }

        public Student GetStudentByName(string Name )
        {
            foreach (Student student in GetAllStudents())
            {
                if (student != null && student.FirstName == Name)
                {
                    return student;
                }
                //return null;
            }
            return null;
        }
        public Student GetStudentById(int id)
        {
            foreach (var student in students)
            {
                if (student != null && student.Id == id)
                {
                    return student; 
                }
            }

            return null; 
        }
        public void removeStudent(int id, bool isSoftDelete)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(int id)
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

    }
}
