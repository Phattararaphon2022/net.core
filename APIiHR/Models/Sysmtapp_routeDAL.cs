using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class Sysmtapp_routeDAL
    {
        public int recid { get; set; }
        public DateTime sysmtapp_route_createdate { get; set; }
        public DateTime sysmtapp_route_modifydate { get; set; }
        public string sysmtapp_route_refcode { get; set; }
        public int sysmtapp_route_refrecid { get; set; }
        public string sysmtapp_route_nextrefcode { get; set; }
        public int sysmtapp_route_nextrefrecid { get; set; }
        public int sysmtapp_route_status { get; set; }
        public int sysmtapp_route_refgroup { get; set; }
        public string sysmtapp_route_refgroupcode { get; set; }
        public string sysmtapp_route_txdesc { get; set; }
    }
}
