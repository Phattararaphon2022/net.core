using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class Sysmttask_linechkDAL
    {
        public int recid { get; set; }
        public DateTime sysmttask_linechk_createdate { get; set; }
        public DateTime sysmttask_linechk_modifydate { get; set; }
        public string sysmttask_linechk_namealian { get; set; }
        public string sysmttask_linechk_txdesc { get; set; }
        public int sysmttask_linechk_status { get; set; }
        public string sysmttask_linechk_code { get; set; }
        public int sysmttask_linechk_level { get; set; }
        public int sysmttask_linechk_refidmaster { get; set; }
        public string sysmttask_linechk_refcodemaster { get; set; }
        public int sysmttask_linechk_refrecid { get; set; }
        public string sysmttask_linechk_worker_code { get; set; }
    }
}
