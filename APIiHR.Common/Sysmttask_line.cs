using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Sysmttask_line 
    {
        [Key]
        public int recid { get; set; }
        public DateTime sysmttask_line_createdate { get; set; }
        public DateTime sysmttask_line_modifydate { get; set; }
        public string sysmttask_line_namealian { get; set; }
        public string sysmttask_line_txdesc { get; set; }
        public int sysmttask_line_status { get; set; }
        public string sysmttask_line_code { get; set; }
        public int sysmttask_line_level { get; set; }
        public int sysmttask_line_refidmaster { get; set; }
        public string sysmttask_line_refcodemaster { get; set; }
        public int sysmttask_line_refrecid { get; set; }
    }
}
