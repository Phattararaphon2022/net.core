using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Apptrans
    {
        [Key]
        public int recid { get; set; }
        public DateTime apptrans_createdate { get; set; }
        public DateTime apptrans_modifydate { get; set; }
        public string apptrans_worker_code { get; set; }
        public string apptrans_refapp { get; set; }
        public int apptrans_level { get; set; }
        public int apptrans_reqgroup { get; set; }
        public string apptrans_workerapp_id { get; set; }
        public int apptrans_status { get; set; }
        public string apptrans_nmmodule { get; set; }
        public int apptrans_codemodule { get; set; }
        public DateTime apptrans_appdate { get; set; }
        public int apptrans_action { get; set; }
    }
}
