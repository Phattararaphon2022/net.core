using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Teamline
    {
        [Key]
        public int recid { get; set; }
        public DateTime teamline_createdate { get; set; }
        public DateTime teamline_modifydate { get; set; }
        public DateTime teamline_startdate { get; set; }
        public DateTime teamline_enddate { get; set; }
        public string teamline_worker_code { get; set; }
        public string teamline_namealian { get; set; }
        public string teamline_txdesc { get; set; }
        public string teamline_level { get; set; }
        public string teamline_codemaster { get; set; }
        public int teamline_status { get; set; }
        public string teamline_workermaster { get; set; }
    }
}
