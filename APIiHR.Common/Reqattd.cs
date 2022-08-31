using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Reqattd
    {
        [Key]
        public int recid { get; set; }
        public DateTime reqattd_datecheckin { get; set; }
        public DateTime reqattd_createdate { get; set; }
        public string reqattd_txdesc { get; set; }
        public string reqattd_type { get; set; }
        public string reqattd_worker_code { get; set; }
        public string reqattd_pathdoc { get; set; }
        public string reqattd_refdesc { get; set; }
        public int reqattd_caltime { get; set; }
        public string reqattd_refcodetran { get; set; }
        public DateTime reqattd_timein { get; set; }
        public DateTime reqattd_timeout { get; set; }

        public string reqattd_ihr_ref1 { get; set; }
        public string reqattd_ihr_ref2 { get; set; }              


    }
}
