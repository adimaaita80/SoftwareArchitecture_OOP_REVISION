using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture_OOP_REVISION
{
    public class Manager : Employee, IPerson
    {
        public string CarPlateNumber { get; set; }
        public string PersonReport(int value)
        {
            return "This is a person report";
        }
    }
}
