using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Reqchgshift
    {   
        [Key]
        public int recid { get; set; }
        public DateTime reqchgshift_datechgnew { get; set; }
        public DateTime reqchgshift_datechgold { get; set; }
        public string reqchgshift_txdesc { get; set; }
        public int reqchgshift_status { get; set; }
        public string reqchgshift_worker_code { get; set; }
        public string reqchgshift_pathdoc { get; set; }
        public string reqchgshift_type { get; set; }
        public DateTime reqchgshift_createdate { get; set; }
        public string reqchgshift_ihr_ref2 { get; set; }
        public string reqchgshift_ihr_ref1 { get; set; }
    }
   
}
