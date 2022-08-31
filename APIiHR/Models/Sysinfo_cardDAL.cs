using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class Sysinfo_cardDAL
    {
        public int recid { get; set; }
        public DateTime sysinfo_card_createdate { get; set; }
        public string sysinfo_card_namealian { get; set; }
        public string sysinfo_card_worker_code { get; set; }
        public string sysinfo_card_idnum { get; set; }
        public DateTime sysinfo_card_expdate { get; set; }
        public string sysinfo_card_status { get; set; }
        public string sysinfo_card_from { get; set; }
        public string sysinfo_card_reftran { get; set; }
        public string sysinfo_card_refdim1 { get; set; }
        public int sysinfo_card_refdimrec { get; set; }
    }
}
