using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class ReqattdDAL
    {
        public int recid { get; set; }
        public DateTime reqattd_datecheckin { get; set; }
        public DateTime reqattd_createdate { get; set; }
        public string reqattd_txdesc { get; set; }
        public string reqattd_type { get; set; }
        public string reqattd_worker_code { get; set; }
        public string reqattd_pathdoc { get; set; }
        public string reqattd_refdesc { get; set; }
        public int reqattd_caltime { get; set; }
        public string reqattd_ihr_ref1 { get; set; }
        public string reqattd_ihr_ref2 { get; set; }

        public string reqattd_refcodetran { get; set; }

    }
}
