using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class SyslogininfoDAL
    {
        public int recid { get; set; }
        public DateTime syslogininfo_createdate { get; set; }
        public DateTime syslogininfo_modifydate { get; set; }
        public DateTime syslogininfo_startdate { get; set; }
        public DateTime syslogininfo_enddate { get; set; }
        public string syslogininfo_txt { get; set; }
        public string syslogininfo_worker_code { get; set; }
        public int syslogininfo_type { get; set; }
        public int syslogininfo_status { get; set; }
    }
}
