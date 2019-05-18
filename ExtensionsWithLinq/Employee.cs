using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsWithLinq
{
    public class Employee
    {
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Salary { get; set; }

        public string String()
        {
            return string.Format("Name:{0} MobileNo:{1} Salary:{2}", Name, MobileNo, Salary);
        }
    }
}
