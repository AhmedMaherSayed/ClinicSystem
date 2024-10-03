using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string History { get; set; }
    }
}
