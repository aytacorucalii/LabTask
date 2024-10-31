using HospitalManagementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementTask.Service
{
    public class AppointmentService : IAppointmentService
    {
        public static List<Appointment> appointments = new List<Appointment>();
        private Appointment appointment;

        public int NewId { get; set; }

        public void AddApointment()
        {
            appointments.Add(appointment);
        }

        public void EndAppointment(int id)
        {
            //int index = -1;
            for (int i = 0; i < NewId; i++)
            {
                if (NewId == i)
                {
                    Console.WriteLine("Vaxt bitdi");
                }
                else
                {
                    throw new Exception("Appointment list daxilinde gonderilen id basa catdi");
                }

            }
        }

        public List<Appointment> GetAllAppointments()
        {
            return appointments;
        }

        public List<Appointment> GetWeeklyAppointments()
        {
            DateTime startOfWeek = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(7);
            List<Appointment> weeklyAppointments = new List<Appointment>();

            foreach (var appointment in appointments)
            {
                if (appointment.StartTime >= startOfWeek && appointment.StartTime < endOfWeek)
                {
                    weeklyAppointments.Add(appointment);
                }
            }

            return weeklyAppointments;
        }


        public List<Appointment> GetTodaylyAppointments()
        {
            DateTime today = DateTime.Today;
            List<Appointment> todayAppointments = new List<Appointment>();

            foreach (var appointment in appointments)
            {
                if (appointment.StartTime.Date == today)
                {
                    todayAppointments.Add(appointment);
                }
            }

            return todayAppointments;
        }


        public List<Appointment> GetAllContinuingAppointment()
        {
            List<Appointment> continuingAppointments = new List<Appointment>();

            foreach (var appointment in appointments)
            {
                if (!appointment.EndTime.HasValue)
                {
                    continuingAppointments.Add(appointment);
                }
            }

            return continuingAppointments;
        }

    }
}
}
