using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.model
{
    class Customer
    {
        
        private String id;
        private String name;
        private String contactNumber;
        private String email;
        private String address;

        public Customer()
        {
        }

        public Customer(string id, string name, string contactNumber, string email, string address)
        {
            this.id = id;
            this.name = name;
            this.contactNumber = contactNumber;
            this.email = email;
            this.address = address;
        }

        public Customer(String id, String name, String contactNumber, String email, String address, ArrayList arlist)
        {
            this.Id = id;
            this.Name = name;
            this.ContactNumber = contactNumber;
            this.Email = email;
            this.Address = address;
            this.Arlist = arlist;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public ArrayList Arlist { get; set; }
        public string Name1 { get => name; set => name = value; }
        public string ContactNumber1 { get => contactNumber; set => contactNumber = value; }
        public string Email1 { get => email; set => email = value; }
        public string Address1 { get => address; set => address = value; }
    }
}
