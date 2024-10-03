using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem
{
    public class Doctor : Account
    {
        public Department Department { get; set; }
        public bool FullAuth { get; set; } = true;
        public WorkingDays WorkingDays { get; set; }

        public void AddAssisstant(Assistant assistant)
        {
            if(assistant is not null && !DataBase.AssistantsList.ContainsKey(assistant.Id))
                DataBase.AssistantsList.Add(assistant.Id, assistant);
        }

        public void GetSchedual()
        {
            Console.WriteLine("Apponiment schedualled Successfully!");
        }
    }
}
