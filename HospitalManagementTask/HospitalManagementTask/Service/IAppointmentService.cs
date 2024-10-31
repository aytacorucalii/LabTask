using HospitalManagementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementTask.Service
{

    public interface IAppointmentService
    {
        void AddApointment();
        void EndAppointment(int id);
        List<Appointment> GetAllAppointments();
        List<Appointment> GetWeeklyAppointments();
        List<Appointment> GetTodaylyAppointments();
        List<Appointment> GetAllContinuingAppointment();
    }
}

