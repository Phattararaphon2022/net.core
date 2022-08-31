using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class ReqotMapper
    {
        public static Reqot MapToCommon(ReqotDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Reqot
            {
                reqot_cutoff = obj.reqot_cutoff,
                reqot_date = obj.reqot_date,
                reqot_desc = obj.reqot_desc,
                reqot_timeafter = obj.reqot_timeafter,
                reqot_timebefore = obj.reqot_timebefore,
                reqot_timenormal = obj.reqot_timenormal,
                reqot_worker_code = obj.reqot_worker_code,
                reqot_refcodetran = obj.reqot_refcodetran,
                reqot_ihr_ref1 = obj.reqot_ihr_ref1,
                reqot_ihr_ref2 = obj.reqot_ihr_ref2
            };
        }
        public static ReqotDAL MapToDto(Reqot obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new ReqotDAL
            {
                reqot_cutoff = obj.reqot_cutoff,
                reqot_date = obj.reqot_date,
                reqot_desc = obj.reqot_desc,
                reqot_timeafter = obj.reqot_timeafter,
                reqot_timebefore = obj.reqot_timebefore,
                reqot_timenormal = obj.reqot_timenormal,
                reqot_worker_code = obj.reqot_worker_code,
                reqot_refcodetran = obj.reqot_refcodetran,
                reqot_ihr_ref1 = obj.reqot_ihr_ref1,
                reqot_ihr_ref2 = obj.reqot_ihr_ref2
            };
        }
    }
}
