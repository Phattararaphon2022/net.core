using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Certf
    {
        [Key]
        public int recid { get; set; }
        public DateTime certf_createdate { get; set; }
        public DateTime certf_modifydate { get; set; }
        public string certf_worker_code { get; set; }
        public int certf_reffile { get; set; }
        public DateTime certf_expdate { get; set; }
        public DateTime certf_repdate { get; set; }
        public string certf_txdesc { get; set; }
        public string certf_name { get; set; }
    }
}
