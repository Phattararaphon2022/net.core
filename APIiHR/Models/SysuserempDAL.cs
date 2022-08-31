using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class SysuserempDAL
    {
        public int recid { get; set; }
        public DateTime sysuseremp_createdate { get; set; }
        public DateTime sysuseremp_modifydate { get; set; }
        public string sysuseremp_worker_code { get; set; }
        public string sysuseremp_name { get; set; }
        public int sysuseremp_status { get; set; }
        public Boolean sysuseremp_lock { get; set; }
        public string sysuseremp_pass { get; set; }
        public string sysuseremp_plaintx { get; set; }
    }
}
