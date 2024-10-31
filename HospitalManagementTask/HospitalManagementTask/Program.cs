using HospitalmanagementTask;
using HospitalManagementTask.Service;
namespace HospitalmanagementTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            AppointmentService appointmentService = new AppointmentService();
            bool isRunning = true;

            while (isRunning)
            {

                Console.WriteLine("1. Appointment yarat");
                Console.WriteLine("2. Appointment-i bitir");
                Console.WriteLine("3. Bütün appointment-lərə bax");
                Console.WriteLine("4. Bu həftəki appointment-lərə bax");
                Console.WriteLine("5. Bugünki appointment-lərə bax");
                Console.WriteLine("6. Bitməmiş appointmentlərə bax");
                Console.WriteLine("7. Menudan çıx");

                Console.Write("Seçim edin: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        appointmentService.AddApointment();
                        break;
                    case 2:
                        Console.Write("Bitirmək istədiyiniz appointment-in ID-ni daxil edin: ");
                        int id = int.Parse(Console.ReadLine());
                        appointmentService.EndAppointment(id);
                        break;
                    case 3:
                        foreach (var app in appointmentService.GetAllAppointments())
                        {
                            Console.WriteLine($"ID: {app.Id}, Pasiyent: {app.PatientName}, Həkim: {app.DoctorName}, Başlama: {app.StartTime}, Bitmə: {app.EndTime}");
                        }
                        break;
                    case 4:
                        foreach (var app in appointmentService.GetWeeklyAppointments())
                        {
                            Console.WriteLine($"ID: {app.Id}, Pasiyent: {app.PatientName}, Həkim: {app.DoctorName}, Başlama: {app.StartTime}");
                        }
                        break;
                    case 5:
                        foreach (var app in appointmentService.GetTodaylyAppointments())
                        {
                            Console.WriteLine($"ID: {app.Id}, Pasiyent: {app.PatientName}, Həkim: {app.DoctorName}, Başlama: {app.StartTime}");
                        }
                        break;
                    case 6:
                        foreach (var app in appointmentService.GetAllContinuingAppointment())
                        {
                            Console.WriteLine($"ID: {app.Id}, Pasiyent: {app.PatientName}, Həkim: {app.DoctorName}, Başlama: {app.StartTime}");
                        }
                        break;
                    case 7:
                        isRunning = false;
                        Console.WriteLine("Çıxış edildi.");
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim etdiniz. Yenidən cəhd edin.");
                        break;
                }
            }
        }
    }
}
  