namespace GroupStudentClassTask
{
    internal class Group
    {
        public string Name { get; set; }
        public string Shift { get; set; }
        public Student[] Students { get; set; }

        public Group()
        {
            Students = new Student[10]; 
        }

        public void AddStudent(Student student)
        {
            bool added = false;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null) 
                {
                    Students[i] = student;
                    Console.WriteLine(student.Name + " qrupa əlavə olundu.");
                    added = true;
                    break;
                }
            }
            if (!added)
            {
                Console.WriteLine("Qrupa əlavə etmək mümkün olmadı, yer yoxdur.");
            }
        }

        public bool FindStudent(string name)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null && Students[i].Name == name)
                {
                    return true; 
                }
            }
            return false; 
        }
    }
}
