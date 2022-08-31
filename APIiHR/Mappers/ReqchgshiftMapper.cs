using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class ReqchgshiftMapper
    {
        public static Reqchgshift MapToCommon(ReqchgshiftDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Reqchgshift
            {
                reqchgshift_datechgnew = obj.reqchgshift_datechgnew,
                reqchgshift_datechgold = obj.reqchgshift_datechgold,
                reqchgshift_txdesc = obj.reqchgshift_txdesc,
                reqchgshift_status = obj.reqchgshift_status,
                reqchgshift_worker_code = obj.reqchgshift_worker_code,
                reqchgshift_pathdoc = obj.reqchgshift_pathdoc,
                reqchgshift_type = obj.reqchgshift_type,
                reqchgshift_ihr_ref1 = obj.reqchgshift_ihr_ref1,
                reqchgshift_ihr_ref2 = obj.reqchgshift_ihr_ref2
            };
        }
        public static ReqchgshiftDAL MapToDto(Reqchgshift obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new ReqchgshiftDAL
            {
                reqchgshift_datechgnew = obj.reqchgshift_datechgnew,
                reqchgshift_datechgold = obj.reqchgshift_datechgold,
                reqchgshift_txdesc = obj.reqchgshift_txdesc,
                reqchgshift_status = obj.reqchgshift_status,
                reqchgshift_worker_code = obj.reqchgshift_worker_code,
                reqchgshift_pathdoc = obj.reqchgshift_pathdoc,
                reqchgshift_type = obj.reqchgshift_type,
                reqchgshift_ihr_ref1 = obj.reqchgshift_ihr_ref1,
                reqchgshift_ihr_ref2 = obj.reqchgshift_ihr_ref2
            };
        }
    }
}
