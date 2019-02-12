using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkomstenbelasting
{
    class Tariffgroup
    {
        private string name;
        private double taxFreeSum;
        private double extra;
        private double extraMax;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double TaxFreeSum
        {
            get { return taxFreeSum; }
            set { taxFreeSum = value; }
        }

        public string Info
        {
            get { return Name + " - €" + TaxFreeSum; }
        }

        public double Extra
        {
            get { return extra; }
            set { extra = value; }
        }

        public double ExtraMax
        {
            get { return extraMax; }
            set { extraMax = value; }
        }

        public Tariffgroup(string tariffgroupName, double tariffgroupTaxFreeSum, double tariffgroupExtra, double tariffgrooupExtraMax)
        {
            name = tariffgroupName;
            taxFreeSum = tariffgroupTaxFreeSum;
            extra = tariffgroupExtra;
            extraMax = tariffgrooupExtraMax;
        }
    }
}
