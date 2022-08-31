using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Reqot
    {
        [Key]
        public int recid { get; set; }
        public int reqot_timebefore { get; set; }
        public int reqot_timenormal { get; set; }
        public int reqot_timeafter { get; set; }
        public string reqot_worker_code { get; set; }
        public int reqot_timetotal { get; set; }
        public DateTime reqot_date { get; set; }
        public string reqot_desc { get; set; }
        public int reqot_cutoff { get; set; }
        public DateTime reqot_createdate { get; set; }
        public string reqot_refcodetran { get; set; }
        public string reqot_ihr_ref1 { get; set; }
        public string reqot_ihr_ref2 { get; set; }
    }
}
