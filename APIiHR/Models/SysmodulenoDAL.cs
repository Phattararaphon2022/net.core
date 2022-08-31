using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class SysmodulenoDAL
    {
        public int recid { get; set; }
        public DateTime sysmoduleno_createdate { get; set; }
        public DateTime sysmoduleno_modifydate { get; set; }
        public string sysmoduleno_code { get; set; }
        public string sysmoduleno_name { get; set; }
        public string sysmoduleno_refname { get; set; }
        public string sysmoduleno_txdesc { get; set; }
        public string sysmoduleno_codeold { get; set; }
        public int sysmoduleno_status { get; set; }
    }
}
