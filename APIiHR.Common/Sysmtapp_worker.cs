using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Sysmtapp_worker
    {
        [Key]
        public int recid { get; set; }
        public DateTime sysmtapp_worker_createdate { get; set; }
        public string sysmtapp_worker_namealian { get; set; }
        public string sysmtapp_worker_worker_code { get; set; }
        public string sysmtapp_worker_status { get; set; }
        public int sysmtapp_worker_refrecid { get; set; }
        public string sysmtapp_worker_refcode { get; set; }
        public string sysmtapp_worker_memtype { get; set; }
        public int sysmtapp_worker_memalert { get; set; }
    }
}
