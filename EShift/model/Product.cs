using EShift.model.pk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.model
{
    class Product
    {
 
        private String serialNumber;
        private int productName;
        private int quantity;
        private Job jobs;

        public Product()
        {
            
        }

        public Product(string serialNumber, int productName, int quantity, Job jobs)
        {
            this.SerialNumber = serialNumber;
            this.ProductName = productName;
            this.Quantity = quantity;
            this.Jobs = jobs;
        }

        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public int ProductName { get => productName; set => productName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        internal Job Jobs { get => jobs; set => jobs = value; }

        public override bool Equals(object obj)
        {
            var product = obj as Product;
            return product != null &&
                   serialNumber == product.serialNumber &&
                   productName == product.productName &&
                   quantity == product.quantity &&
                   EqualityComparer<Job>.Default.Equals(jobs, product.jobs);
        }

        public override int GetHashCode()
        {
            var hashCode = 1820517680;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(serialNumber);
            hashCode = hashCode * -1521134295 + productName.GetHashCode();
            hashCode = hashCode * -1521134295 + quantity.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Job>.Default.GetHashCode(jobs);
            return hashCode;
        }
    }
}
