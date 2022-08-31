using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class CheckinpoiDAL
    {
        public int recid { get; set; }
        public DateTime checkinpoi_createdate { get; set; }
        public DateTime checkinpoi_modifydate { get; set; }
        public string checkinpoi_worker_code { get; set; }
        public string checkinpoi_code { get; set; }
        public float checkinpoi_lat { get; set; }
        public float checkinpoi_lng { get; set; }
        public int checkinpoi_typeio { get; set; }
    }
}
