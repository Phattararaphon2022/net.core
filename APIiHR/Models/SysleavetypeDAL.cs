using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class SysleavetypeDAL
    {
        public int recid { get; set; }
        public DateTime sysleavetype_createdate { get; set; }
        public string sysleavetype_txdesc { get; set; }
        public string sysleavetype_refpoli { get; set; }
        public string sysleavetype_comuser { get; set; }
        public int sysleavetype_maxdays { get; set; }
        public string sysleavetype_refcode { get; set; }
    }
}
