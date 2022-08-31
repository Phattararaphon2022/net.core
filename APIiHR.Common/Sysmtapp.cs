using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Sysmtapp
    {
        [Key]
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
