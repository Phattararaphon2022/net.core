using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class EmpMain
    {
        [Key]
        public string EmpID { get; set; }
        public string CompID { get; set; }
        public string EmpFName { get; set; }
        public string EmpLName { get; set; }
        public string EmpFNameT { get; set; }
        public string EmpLNameT { get; set; }
    }
}
