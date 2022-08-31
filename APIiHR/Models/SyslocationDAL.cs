using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class SyslocationDAL
    {
        public int recid { get; set; }
        public DateTime syslocation_createdate { get; set; }
        public DateTime syslocation_modifydate { get; set; }
        public string syslocation_name { get; set; }
        public string syslocation_txcomm { get; set; }
        public string syslocation_code { get; set; }
        public int syslocation_status { get; set; }
    }
}
