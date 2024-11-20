using AcademymanagementLabTask.Contexts;
using AcademymanagementLabTask.Models;
using AcademymanagementLabTask.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademymanagementLabTask.Services.Concretes;

public class StudentService : IStudentService
{
    public void CreateStudent(Student student)
    {
        AcademyManagementDbContexts db= new AcademyManagementDbContexts();
        db.students.Add(student);
        db.SaveChanges();
    }

    public List<Student> GetAllActiveStudents()
    {
        using var db = new AcademyManagementDbContexts();
        return db.students.Where(s => s.IsDeleted).ToList();
    }

    public List<Student> GetAllStudents()
    {
        using var db = new AcademyManagementDbContexts();
        return db.students.ToList();
    }

    public List<Student> GetStudensByEnrollmentDate(int days)
    {
        throw new NotImplementedException();
    }

    public Student GetStudentById(int id)
    {
        using var db = new AcademyManagementDbContexts();
        return db.students.FirstOrDefault(s => s.Id == id);
    }

    public List<Student> GetStudentsByName(string name)
    {
        using var db = new AcademyManagementDbContexts();
        return db.students.FirstOrDefault(s => s.FistName == name);
    }

    public void HardDeleteStudent(int id)
    {
        throw new NotImplementedException();
    }

    public void SoftDeleteStudent(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateStudent(int id, Student student)
    {
        throw new NotImplementedException();
    }
}
