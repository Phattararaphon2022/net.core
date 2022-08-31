using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class SysmtappDAL
    {
        public int recid { get; set; }
        public DateTime sysmtapp_createdate { get; set; }
        public string sysmtapp_namealian { get; set; }
        public string sysmtapp_txdesc { get; set; }
        public string sysmtapp_status { get; set; }
        public string sysmtapp_code { get; set; }
        public string sysmtapp_nextmt { get; set; }
        public bool sysmtapp_master { get; set; }
        public int sysmtapp_nextmtrec { get; set; }
    }
}
