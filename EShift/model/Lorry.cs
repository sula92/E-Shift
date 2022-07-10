using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.model
{
    class Lorry
    {
        private String id;
        private String model;
        private String status;
        private Unit unit;

        public Lorry()
        {
            
        }

        public Lorry(string id, string model, string status, Unit unit)
        {
            this.Id = id;
            this.Model = model;
            this.Status = status;
            this.Unit = unit;
        }

        public string Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
        public string Status { get => status; set => status = value; }
        internal Unit Unit { get => unit; set => unit = value; }

        public override bool Equals(object obj)
        {
            var lorry = obj as Lorry;
            return lorry != null &&
                   id == lorry.id &&
                   model == lorry.model &&
                   status == lorry.status &&
                   EqualityComparer<Unit>.Default.Equals(unit, lorry.unit);
        }

        public override int GetHashCode()
        {
            var hashCode = -1977323736;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(model);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(status);
            hashCode = hashCode * -1521134295 + EqualityComparer<Unit>.Default.GetHashCode(unit);
            return hashCode;
        }
    }
}
