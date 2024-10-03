using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem
{
    public static class DataBase
    {
        public static Dictionary<string, Appoinment> AppoinmentsList { get; set; }  = new Dictionary<string, Appoinment>();
        public static Dictionary<int, Customer> CustomersList { get; set; } = new Dictionary<int, Customer>();
        public static Dictionary<int, Assistant> AssistantsList { get; set; } = new Dictionary<int, Assistant>();

        public static bool InsertAppoinment(Appoinment obj)
        {
            if(obj is not null)
            {
                AppoinmentsList.Add($"{obj.Date},{obj.Time}",obj);
                return true;
            }
            return false;
        }

        public static bool InsertCustomer(Customer obj)
        {
            if (obj is not null)
            {
                CustomersList.Add(obj.Id, obj);
                return true;
            }
            return false;
        }
        
        public static bool InsertAssistant(Assistant obj)
        {
            if (obj is not null)
            {
                AssistantsList.Add(obj.Id, obj);
                return true;
            }
            return false;
        }

        public static bool UpdateAppoinment(Appoinment obj)
        {
            if (AppoinmentsList[$"{obj.Date},{obj.Time}"] is not null)
            {
                AppoinmentsList[$"{obj.Customer.Id},{obj.Doctor.Id}"].Assistant = obj.Assistant;
                AppoinmentsList[$"{obj.Customer.Id},{obj.Doctor.Id}"].Date = obj.Date;
                AppoinmentsList[$"{obj.Customer.Id},{obj.Doctor.Id}"].Time = obj.Time;
                AppoinmentsList[$"{obj.Customer.Id},{obj.Doctor.Id}"].Customer = obj.Customer;
                AppoinmentsList[$"{obj.Customer.Id},{obj.Doctor.Id}"].Status = obj.Status;
                AppoinmentsList[$"{obj.Customer.Id},{obj.Doctor.Id}"].Doctor = obj.Doctor;
                AppoinmentsList[$"{obj.Customer.Id},{obj.Doctor.Id}"].TotalPrice = obj.TotalPrice;

                return true;
            }
            return false;
        }

        public static bool UpdateCustomer(Customer obj)
        {
            if (CustomersList[obj.Id] is not null)
            {
                CustomersList[obj.Id].Id = obj.Id;
                CustomersList[obj.Id].Address = obj.Address;
                CustomersList[obj.Id].Name = obj.Name;
                CustomersList[obj.Id].Age = obj.Age;
                CustomersList[obj.Id].Gender = obj.Gender;
                CustomersList[obj.Id].History = obj.History;

                return true;
            }
            return false;
        }

        public static bool UpdateAssistant(Assistant obj)
        {
            if (AssistantsList[obj.Id] is not null)
            {
                AssistantsList[obj.Id] = obj;

                return true;
            }
            return false;
        }

        public static bool DeleteCustomer(Customer obj)
        {
            if(obj is not null)
            {
                if (CustomersList[obj.Id] is not null)
                    CustomersList.Remove(obj.Id);
                return true;
            }
            return false;
        }
        
        public static bool DeleteAssistant(Assistant obj)
        {
            if(obj is not null)
            {
                if (AssistantsList[obj.Id] is not null)
                    AssistantsList.Remove(obj.Id);
                return true;
            }
            return false;
        }

        public static bool DeleteAppoinment(Appoinment obj)
        {
            if(obj is not null && AppoinmentsList[$"{obj.Date},{obj.Time}"] is not null)
            {
                AppoinmentsList.Remove($"{obj.Date},{obj.Time}");
                return true;
            }
            return false;
        }
    }
}
