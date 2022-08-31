using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class SysfileessDAL
    {
        
        public int recid { get; set; }
        public DateTime sysfileess_createdate { get; set; }
        public string sysfileess_txdesc { get; set; }
        public string sysfileess_worker_code { get; set; }
        public string sysfileess_refmod { get; set; }
        public string sysfileess_refdim1 { get; set; }
        public string sysfileess_refdim2 { get; set; }
        public string sysfileess_refdim3 { get; set; }
        public string sysfileess_filename { get; set; }
        public byte[] sysfileess_filedata { get; set; }
    }
}
