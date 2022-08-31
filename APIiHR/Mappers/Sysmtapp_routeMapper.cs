using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class Sysmtapp_routeMapper
    {
        public static Sysmtapp_route MapToCommon(Sysmtapp_routeDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmtapp_route
            {

                sysmtapp_route_refcode = obj.sysmtapp_route_refcode,
                sysmtapp_route_refrecid = obj.sysmtapp_route_refrecid,
                sysmtapp_route_nextrefcode = obj.sysmtapp_route_nextrefcode,
                sysmtapp_route_nextrefrecid = obj.sysmtapp_route_nextrefrecid,
                sysmtapp_route_status = obj.sysmtapp_route_status,
                sysmtapp_route_refgroup = obj.sysmtapp_route_refgroup,
                sysmtapp_route_refgroupcode = obj.sysmtapp_route_refgroupcode,
                sysmtapp_route_txdesc = obj.sysmtapp_route_txdesc
            };
        }
        public static Sysmtapp_routeDAL MapToDto(Sysmtapp_route obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmtapp_routeDAL
            {
                sysmtapp_route_refcode = obj.sysmtapp_route_refcode,
                sysmtapp_route_refrecid = obj.sysmtapp_route_refrecid,
                sysmtapp_route_nextrefcode = obj.sysmtapp_route_nextrefcode,
                sysmtapp_route_nextrefrecid = obj.sysmtapp_route_nextrefrecid,
                sysmtapp_route_status = obj.sysmtapp_route_status,
                sysmtapp_route_refgroup = obj.sysmtapp_route_refgroup,
                sysmtapp_route_refgroupcode = obj.sysmtapp_route_refgroupcode,
                sysmtapp_route_txdesc = obj.sysmtapp_route_txdesc
            };
        }
    }
}
