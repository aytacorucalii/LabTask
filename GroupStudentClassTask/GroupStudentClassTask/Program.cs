namespace GroupStudentClassTask
{

    internal class Program
    {
        static void Main(string[] args)
        {



           
            Student student1 = new Student();
            student1.Name = "Aytac";
            student1.Surname = "Orucaliyeva";
            student1.Gender = "Female";
            student1.Age = 20;
            student1.PhoneNumber = "0551234567";
            student1.Limit = 3;
            student1.Group = "Group1";



        
            Group group1 = new Group();
            group1.Name = "Group1";
            group1.Shift = "Morning";






            // 3. Tələbəni qrupa əlavə et
            group1.AddStudent(student1);




            if (group1.FindStudent("Aytac"))
            {
                Console.WriteLine("Tələbə qrupa əlavə olundu.");
            }
            else
            {
                Console.WriteLine("Tələbə qrupa əlavə olunmadı.");
            }
        }


        internal class Student
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public string PhoneNumber { get; set; }
            public string Group { get; set; }

            private int limit;

            public int Limit
            {
                get { return limit; }
                set
                {
                    if (value >= 0)
                    {
                        limit = value;
                    }
                }
            }

            public void Absent()
            {
                if (Limit > 0)
                {
                    Limit--;
                    Console.WriteLine("Telebe bu gun derse gelmeyib.");
                }
                else
                {
                    Console.WriteLine("Kesildiniz.");
                }
            }
        }
    }}
