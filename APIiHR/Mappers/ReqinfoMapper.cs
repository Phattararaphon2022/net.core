using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class ReqinfoMapper 
    {
        public static Reqinfo MapToCommon(ReqinfoDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Reqinfo
            {
                reqinfo_createdate = obj.reqinfo_createdate,
                reqinfo_infotext = obj.reqinfo_infotext,
                reqinfo_txdesc = obj.reqinfo_txdesc,
                reqinfo_worker_code = obj.reqinfo_worker_code,
                reqinfo_status = obj.reqinfo_status,
                reqinfo_ihr_ref1 = obj.reqinfo_ihr_ref1,
                reqinfo_ihr_ref2 = obj.reqinfo_ihr_ref2

            };
        }
        public static ReqinfoDAL MapToDto(Reqinfo obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new ReqinfoDAL
            {
                reqinfo_createdate = obj.reqinfo_createdate,
                reqinfo_infotext = obj.reqinfo_infotext,
                reqinfo_txdesc = obj.reqinfo_txdesc,
                reqinfo_worker_code = obj.reqinfo_worker_code,
                reqinfo_status = obj.reqinfo_status,
                reqinfo_ihr_ref1 = obj.reqinfo_ihr_ref1,
                reqinfo_ihr_ref2 = obj.reqinfo_ihr_ref2
                
            };
        }
    }
}
