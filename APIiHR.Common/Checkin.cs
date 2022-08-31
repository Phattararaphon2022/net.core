using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Checkin
    {
        [Key]
        public int recid { get; set; }
        public DateTime checkin_createdate { get; set; }
        public DateTime checkin_modifydate { get; set; }
        public string checkin_txdesc { get; set; }
        public string checkin_worker_code { get; set; }
        public DateTime checkin_datestart { get; set; }
        public DateTime checkin_datestartstamp { get; set; }
        public DateTime checkin_dateend { get; set; }
        public DateTime checkin_dateendstamp { get; set; }
        public int checkin_status { get; set; }
        public string checkin_mastercode { get; set; }
        public string checkin_dim1 { get; set; }
        public int checkin_level { get; set; }

    }
}
