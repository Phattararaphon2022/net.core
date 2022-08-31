using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class PdpaformDAL
    {
        public int recid { get; set; }
        public DateTime pdpaform_createdate { get; set; }
        public DateTime pdpaform_modifydate { get; set; }
        public string pdpaform_worker_code { get; set; }
        public string pdpaform_refidfileatt { get; set; }
        public int pdpaform_refidapp { get; set; }
        public string pdpaform_startappcode { get; set; }
        public string pdpaform_emailadd { get; set; }
        public string pdpaform_infotype1 { get; set; }
        public string pdpaform_infotype2 { get; set; }
        public string pdpaform_txdesc { get; set; }
        public Boolean pdpaform_person { get; set; }
        public string pdpaform_fname { get; set; }
        public string pdpaform_lname { get; set; }
        public int pdpaform_status { get; set; }

    }
}
