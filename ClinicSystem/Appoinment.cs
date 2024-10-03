using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem
{
    public class Appoinment
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public Customer Customer { get; set; }
        public Assistant Assistant { get; set; }
        public Doctor Doctor { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Status { get; set; }

        public bool AppoinentDcotorAvailablity(DateOnly date, TimeOnly time)
        {
            if (TimeUntaked(date, time))
            {
                Date = date;
                Time = time;
                var apponiment = new Appoinment();
                apponiment.Date = date;
                apponiment.Time = time;
                apponiment.Customer = Customer;
                apponiment.Assistant = Assistant;
                apponiment.Doctor = Doctor;
                apponiment.TotalPrice = TotalPrice;
                apponiment.Status = Status;

                DataBase.AppoinmentsList.Add($"{date},{time}", apponiment);
                return true;
            }
            return false;
        }

        public bool TimeUntaked(DateOnly date, TimeOnly time)
        {
            if (date.Day > DateTime.Now.Day
                && date.Month > DateTime.Now.Month
                && date.Year > DateTime.Now.Year
                && DataBase.AppoinmentsList[$"{date},{time}"] is null)
                return true;

            return false;
        }
    }
}
