using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class SysmttaskDAL
    {
        public int recid { get; set; }
        public DateTime sysmttask_createdate { get; set; }
        public string sysmttask_namealian { get; set; }
        public string sysmttask_txdesc { get; set; }
        public int sysmttask_status { get; set; }
        public string sysmttask_code { get; set; }
        public int sysmttask_level { get; set; }
        public int sysmttask_refdim1 { get; set; }
        public int sysmttask_refdim2 { get; set; }
    }
}
