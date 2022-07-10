using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.model
{
    class User
    {
        private String userId;
        private Employee employee;
        private String privilege;
        private String password;

        public User()
        {
            
        }

        public User(string userId, Employee employee, string privilege, string password)
        {
            this.UserId = userId;
            this.Employee = employee;
            this.Privilege = privilege;
            this.Password = password;
        }

        public string UserId { get => userId; set => userId = value; }
        public string Privilege { get => privilege; set => privilege = value; }
        public string Password { get => password; set => password = value; }
        internal Employee Employee { get => employee; set => employee = value; }
    }
}
