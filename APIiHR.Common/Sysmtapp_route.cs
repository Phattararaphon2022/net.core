using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Common
{
    public class Sysmtapp_route
    {
        [Key]
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
