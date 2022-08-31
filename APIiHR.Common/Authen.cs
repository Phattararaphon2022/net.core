using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace APIiHR.Common
{
    public class Authen
    {
        [Key]

        public string CompID { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public string UserType { get; set; }
        public string NameT { get; set; }
        public string NameE { get; set; }
        public string EmpID { get; set; }
    }
}