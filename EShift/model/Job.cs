using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.model
{
    class Job
    {
     private String id;
     private Customer customer;
     private DateTime date;
     private String startingAddress;
     private String destinationAddress;

        public Job()
        {
           
        }

        public Job(string id, Customer customer, DateTime date, string startingAddress, string destinationAddress)
        {
            this.Id = id;
            this.Customer = customer;
            this.Date = date;
            this.StartingAddress = startingAddress;
            this.DestinationAddress = destinationAddress;
        }

        public string Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string StartingAddress { get => startingAddress; set => startingAddress = value; }
        public string DestinationAddress { get => destinationAddress; set => destinationAddress = value; }
        internal Customer Customer { get => customer; set => customer = value; }

        public override bool Equals(object obj)
        {
            var job = obj as Job;
            return job != null &&
                   id == job.id &&
                   EqualityComparer<Customer>.Default.Equals(customer, job.customer) &&
                   date == job.date &&
                   startingAddress == job.startingAddress &&
                   destinationAddress == job.destinationAddress;
        }

        public override int GetHashCode()
        {
            var hashCode = 1148113878;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(customer);
            hashCode = hashCode * -1521134295 + date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(startingAddress);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(destinationAddress);
            return hashCode;
        }
    }
}
