using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class WorkflowtranDAL
    {
        public int recid { get; set; }
        public DateTime workflowtran_createdate { get; set; }
        public DateTime workflowtran_modifydate { get; set; }
        public string workflowtran_worker_code { get; set; }
        public string workflowtran_reftype { get; set; }
        public string workflowtran_refmodule { get; set; }
        public string workflowtran_txdesc { get; set; }
        public int workflowtran_status { get; set; }
        public string workflowtran_nextstate { get; set; }
        public int workflowtran_refworkflowid { get; set; }
        public string workflowtran_txcomm { get; set; }
        public string workflowtran_appworkid { get; set; }
        public int workflowtran_nextrecid { get; set; }
    }
}
