using CustomReflection.Models;
using System.Reflection;
using System.Xml.Linq;

namespace CustomReflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            User userr = new User("Aytac", "Orucali", 20);
            //userr.GetFullName();
            //User.ChangeAge(33);
           // Console.WriteLine($"Yeni Yaş: {User.GetAge()}");
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            // constructorInfo
            //foreach (Type type in types)
            //{
            //    foreach (ConstructorInfo item in type.GetConstructors())
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine(type.Name);
            //}



            // propertyInfo
            //foreach (Type type in types)
            //{
            //    foreach (PropertyInfo item in type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance))
            //    {
            //        Console.WriteLine(item);
            //    }



            //}
            //foreach (Type type in types)
            //{
            //    foreach (PropertyInfo item in type.GetProperties(BindingFlags.NonPublic | BindingFlags.Static))
            //    {
            //        Console.WriteLine(item);
            //    }

            //}

            //set Name
            //foreach (Type item in types)
            //{
            //    Console.WriteLine(item.GetProperty("Name",BindingFlags.NonPublic | BindingFlags.Instance ));
            //}
            //Type userType = typeof(User);
            //PropertyInfo? privateProperty = userType.GetProperty("Name", BindingFlags.NonPublic | BindingFlags.Instance );
            //privateProperty.SetValue(userr, "Name2");
            //Console.WriteLine( privateProperty.GetValue(userr));





                     // set age
            foreach (Type item in types)
            {
                foreach (var item1 in types)
                {
                    Console.WriteLine(item1.GetEnumValues());
                }
                Console.WriteLine(item.GetProperty("Age", BindingFlags.NonPublic | BindingFlags.Static));
            }
            Type userrType = typeof(User);
            PropertyInfo? staticProperty = userrType.GetProperty("Age", BindingFlags.NonPublic | BindingFlags.Static);
            staticProperty.SetValue(userr, 22);
            Console.WriteLine(staticProperty.GetValue(userr));




            //set Id
            //foreach (Type item in types)
            //{
            //    Console.WriteLine(item.GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Static));
            //}
            //Type userID = typeof(User);
            //PropertyInfo? IdProperty = userID.GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Static);
            //IdProperty.SetValue(userr,"453737");
            //Console.WriteLine(IdProperty.GetValue(userr));



        }
    }
}
