using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.model
{
    class Container
    {
        private String id;
        private String maxWeight;
        private Unit units;

        public Container()
        {
            
        }

        public Container(string id, string maxWeight, Unit units)
        {
            this.Id = id;
            this.MaxWeight = maxWeight;
            this.Units = units;
        }

        public string Id { get => id; set => id = value; }
        public string MaxWeight { get => maxWeight; set => maxWeight = value; }
        internal Unit Units { get => units; set => units = value; }

        public override bool Equals(object obj)
        {
            var container = obj as Container;
            return container != null &&
                   id == container.id &&
                   maxWeight == container.maxWeight &&
                   EqualityComparer<Unit>.Default.Equals(units, container.units);
        }

        public override int GetHashCode()
        {
            var hashCode = -310344911;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(maxWeight);
            hashCode = hashCode * -1521134295 + EqualityComparer<Unit>.Default.GetHashCode(units);
            return hashCode;
        }
    }
}
