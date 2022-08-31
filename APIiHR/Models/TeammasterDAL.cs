using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class TeammasterDAL
    {
        public int recid { get; set; }
        public DateTime teammaster_createdate { get; set; }
        public DateTime teammaster_modifydate { get; set; }
        public string teammaster_worker_code { get; set; }
        public string teammaster_namealian { get; set; }
        public string teammaster_txdesc { get; set; }
        public string teammaster_code { get; set; }
        public int teammaster_status { get; set; }
    }
}
