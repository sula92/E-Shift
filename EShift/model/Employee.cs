using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.model
{
    class Employee
    {
        private String id;
        private String name;
        private String position;
        private String contactNumber;
        private String email;
        private Unit unit;

        public Employee()
        {
           
        }

        public Employee(string id, string name, string position, string contactNumber, string email, Unit unit)
        {
            this.Id = id;
            this.Name = name;
            this.Position = position;
            this.ContactNumber = contactNumber;
            this.Email = email;
            this.Unit = unit;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Email { get => email; set => email = value; }
        internal Unit Unit { get => unit; set => unit = value; }

        public override bool Equals(object obj)
        {
            var employee = obj as Employee;
            return employee != null &&
                   id == employee.id &&
                   name == employee.name &&
                   position == employee.position &&
                   contactNumber == employee.contactNumber &&
                   email == employee.email &&
                   EqualityComparer<Unit>.Default.Equals(unit, employee.unit);
        }

        public override int GetHashCode()
        {
            var hashCode = -724604888;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(position);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(contactNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            hashCode = hashCode * -1521134295 + EqualityComparer<Unit>.Default.GetHashCode(unit);
            return hashCode;
        }
    }
}
