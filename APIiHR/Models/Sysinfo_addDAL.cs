using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class Sysinfo_addDAL
    {
        public int recid { get; set; }
        public DateTime sysinfo_add_createdate { get; set; }
        public string sysinfo_add_namealian { get; set; }
        public string sysinfo_add_worker_code { get; set; }
        public string sysinfo_add_moo { get; set; }
        public string sysinfo_add_soi { get; set; }
        public string sysinfo_add_road { get; set; }
        public string sysinfo_add_tambon { get; set; }
        public string sysinfo_add_amphur { get; set; }
        public string sysinfo_add_province { get; set; }
        public string sysinfo_add_addressno { get; set; }
        public string sysinfo_add_zipcode { get; set; }
        public string sysinfo_add_status { get; set; }
        public string sysinfo_add_reftran { get; set; }
        public string sysinfo_add_refdim1 { get; set; }
        public int sysinfo_add_refdimrec { get; set; }
    }
}
