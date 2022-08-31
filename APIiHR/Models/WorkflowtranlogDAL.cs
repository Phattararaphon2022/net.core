using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class WorkflowtranlogDAL
    {
        public int recid { get; set; }
        public DateTime workflowtranlog_createdate { get; set; }
        public DateTime workflowtranlog_modifydate { get; set; }
        public string workflowtranlog_codeapp { get; set; }
        public string workflowtranlog_codereq { get; set; }
        public string workflowtranlog_txdesc { get; set; }
        public string workflowtranlog_module { get; set; }
        public int workflowtranlog_status { get; set; }
    }
}
