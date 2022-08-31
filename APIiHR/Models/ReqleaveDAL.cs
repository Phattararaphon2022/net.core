using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class ReqleaveDAL
    {
        public int recid { get; set; }
        public DateTime reqleave_dateleave { get; set; }
        public DateTime reqleave_fulldate { get; set; }
        public string reqleave_txdesc { get; set; }
        public string reqleave_infodesc { get; set; }
        public string reqleave_worker_code { get; set; }
        public int reqleave_status { get; set; }
        public int reqleave_cutoff { get; set; }
        public string reqleave_filepath { get; set; }
        public DateTime reqleave_createdate { get; set; }

        public string reqleave_reftype { get; set; }
        public string reqleave_datetype { get; set; }
        public int reqleave_dateqty { get; set; }
        public string reqleave_ihr_ref1 { get; set; }
        public string reqleave_ihr_ref2 { get; set; }

    }
}
