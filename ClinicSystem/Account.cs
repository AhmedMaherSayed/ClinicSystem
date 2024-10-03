using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem
{
    public class Account : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Shift Shift { get; set; }
        public bool IsOnline { get; set; }
        public DateTime LastLogedIn { get; set; }
        private string _username { get; set; }
        private string _password { get; set; }

        public bool Login(string username, string password)
        {
            if(username is not null && password is not null)
            {
                _username = username;
                _password = password;
                IsOnline = true;
                return true;
            }
            return false;
            
        }

        public bool Logout()
        {
            IsOnline = false;
            return false;
        }

        public override string ToString()
            => $"Account Id = {Id} :: name = {Name} :: is online = {IsOnline}";
    }
}
