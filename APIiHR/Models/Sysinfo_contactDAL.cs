using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class Sysinfo_contactDAL
    {
        public int recid { get; set; }
        public DateTime sysinfo_contact_createdate { get; set; }
        public DateTime sysinfo_contact_modifydate { get; set; }
        public string sysinfo_contact_worker_code { get; set; }
        public string sysinfo_contact_name { get; set; }
        public string sysinfo_contact_mobile { get; set; }
        public string sysinfo_contact_tel { get; set; }
        public string sysinfo_contact_address { get; set; }
        public int sysinfo_contact_status { get; set; }
        public string sysinfo_contact_reftran { get; set; }
        public string sysinfo_contact_refdim1 { get; set; }
        public int sysinfo_contact_refdimrec { get; set; }
    }
}
