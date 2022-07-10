using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.model
{
    class Unit
    {
    private String id;
    private Job job;
    private Employee driver;
    private Employee assistant;
    private Container container;  
    private Lorry lorry;

        public Unit()
        {
            
        }

        public Unit(string id, Job job, Employee driver, Employee assistant, Container container, Lorry lorry)
        {
            this.Id = id;
            this.Job = job;
            this.Driver = driver;
            this.Assistant = assistant;
            this.Container = container;
            this.Lorry = lorry;
        }

        public string Id { get => id; set => id = value; }
        internal Job Job { get => job; set => job = value; }
        internal Employee Driver { get => driver; set => driver = value; }
        internal Employee Assistant { get => assistant; set => assistant = value; }
        internal Container Container { get => container; set => container = value; }
        internal Lorry Lorry { get => lorry; set => lorry = value; }

        public override bool Equals(object obj)
        {
            var unit = obj as Unit;
            return unit != null &&
                   id == unit.id &&
                   EqualityComparer<Job>.Default.Equals(job, unit.job) &&
                   EqualityComparer<Employee>.Default.Equals(driver, unit.driver) &&
                   EqualityComparer<Employee>.Default.Equals(assistant, unit.assistant) &&
                   EqualityComparer<Container>.Default.Equals(container, unit.container) &&
                   EqualityComparer<Lorry>.Default.Equals(lorry, unit.lorry);
        }

        public override int GetHashCode()
        {
            var hashCode = -1176017115;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<Job>.Default.GetHashCode(job);
            hashCode = hashCode * -1521134295 + EqualityComparer<Employee>.Default.GetHashCode(driver);
            hashCode = hashCode * -1521134295 + EqualityComparer<Employee>.Default.GetHashCode(assistant);
            hashCode = hashCode * -1521134295 + EqualityComparer<Container>.Default.GetHashCode(container);
            hashCode = hashCode * -1521134295 + EqualityComparer<Lorry>.Default.GetHashCode(lorry);
            return hashCode;
        }
    }
}
