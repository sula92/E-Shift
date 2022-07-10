using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.model.pk
{
    class ProductPK
    {
        private String job;
        private String productName;

        public ProductPK()
        {
            
        }

        public ProductPK(string job, string productName)
        {
            this.Job = job;
            this.ProductName = productName;
        }

        public string Job { get => job; set => job = value; }
        public string ProductName { get => productName; set => productName = value; }

        public override bool Equals(object obj)
        {
            var pK = obj as ProductPK;
            return pK != null &&
                   job == pK.job &&
                   productName == pK.productName;
        }

        public override int GetHashCode()
        {
            var hashCode = -2116969341;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(job);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(productName);
            return hashCode;
        }
    }
}
