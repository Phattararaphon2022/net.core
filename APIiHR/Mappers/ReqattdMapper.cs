using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class ReqattdMapper 
    {
        public static Reqattd MapToCommon(ReqattdDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Reqattd
            {
                reqattd_datecheckin = obj.reqattd_datecheckin,
                reqattd_createdate = obj.reqattd_createdate,
                reqattd_txdesc = obj.reqattd_txdesc,
                reqattd_type = obj.reqattd_type,
                reqattd_worker_code = obj.reqattd_worker_code,
                reqattd_pathdoc = obj.reqattd_pathdoc,
                reqattd_refdesc = obj.reqattd_refdesc,
                reqattd_caltime = obj.reqattd_caltime,
                reqattd_refcodetran = obj.reqattd_refcodetran,
                reqattd_ihr_ref1 = obj.reqattd_ihr_ref1,
                reqattd_ihr_ref2 = obj.reqattd_ihr_ref2
            };
        }
        public static ReqattdDAL MapToDto(Reqattd obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new ReqattdDAL
            {
                reqattd_datecheckin = obj.reqattd_datecheckin,
                reqattd_createdate = obj.reqattd_createdate,
                reqattd_txdesc = obj.reqattd_txdesc,
                reqattd_type = obj.reqattd_type,
                reqattd_worker_code = obj.reqattd_worker_code,
                reqattd_pathdoc = obj.reqattd_pathdoc,
                reqattd_refdesc = obj.reqattd_refdesc,
                reqattd_caltime = obj.reqattd_caltime,
                reqattd_refcodetran = obj.reqattd_refcodetran,
                reqattd_ihr_ref1 = obj.reqattd_ihr_ref1,
                reqattd_ihr_ref2 = obj.reqattd_ihr_ref2
                
            };
        }
    }
}
