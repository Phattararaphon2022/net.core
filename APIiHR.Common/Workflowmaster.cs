using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Workflowmaster
    {
        [Key]
        public int recid { get; set; }
        public DateTime workflowmaster_createdate { get; set; }
        public string workflowmaster_txdesc { get; set; }
        public string workflowmaster_group { get; set; }
        public string workflowmaster_refgroup { get; set; }
        public string workflowmaster_refdim1 { get; set; }
        public string workflowmaster_refdim2 { get; set; }
        public string workflowmaster_active { get; set; }
        public Boolean workflowmaster_process { get; set; }

    }
}
