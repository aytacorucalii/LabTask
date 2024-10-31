using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementTask.Models
{
    public class Appointment
    {
        public static int NewId = 1;
        public int Id { get; set; }
        public string? PatientName { get; set; }
        public string? DoctorName { get; set; }
        public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime? EndTime { get; set; }

        public Appointment()
        {
            Id = NewId++;
            StartTime = DateTime.Now;
            EndTime = null;
        }
    }
}
