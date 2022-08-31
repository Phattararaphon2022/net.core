using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class ReqinfoDAL
    {
        public int recid { get; set; }
        public DateTime reqinfo_createdate { get; set; }
        public string reqinfo_infotext { get; set; }
        public string reqinfo_txdesc { get; set; }
        public string reqinfo_worker_code { get; set; }
        public int reqinfo_status { get; set; }
        public string reqinfo_ihr_ref1 { get; set; }
        public string reqinfo_ihr_ref2 { get; set; }
    }
}
