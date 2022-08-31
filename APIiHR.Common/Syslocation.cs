using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Syslocation
    {
        [Key]
        public int recid { get; set; }
        public DateTime syslocation_createdate { get; set; }
        public DateTime syslocation_modifydate { get; set; }
        public string syslocation_name { get; set; }
        public string syslocation_txcomm { get; set; }
        public string syslocation_code { get; set; }
        public int syslocation_status { get; set; }
    }
}
