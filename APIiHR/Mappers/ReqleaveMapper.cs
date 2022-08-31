using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class ReqleaveMapper
    {
        public static Reqleave MapToCommon(ReqleaveDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Reqleave
            {
                
                reqleave_dateleave = obj.reqleave_dateleave,
                reqleave_fulldate = obj.reqleave_fulldate,
                reqleave_txdesc = obj.reqleave_txdesc,
                reqleave_infodesc = obj.reqleave_infodesc,
                reqleave_worker_code = obj.reqleave_worker_code,
                reqleave_status = obj.reqleave_status,
                reqleave_cutoff = obj.reqleave_cutoff,
                reqleave_filepath = obj.reqleave_filepath,

                reqleave_reftype = obj.reqleave_reftype,
                reqleave_datetype = obj.reqleave_datetype,
                reqleave_dateqty = obj.reqleave_dateqty,
                reqleave_ihr_ref1 = obj.reqleave_ihr_ref1,
                reqleave_ihr_ref2 = obj.reqleave_ihr_ref2
            };
        }
        public static ReqleaveDAL MapToDto(Reqleave obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new ReqleaveDAL
            {
                reqleave_dateleave = obj.reqleave_dateleave,
                reqleave_fulldate = obj.reqleave_fulldate,
                reqleave_txdesc = obj.reqleave_txdesc,
                reqleave_infodesc = obj.reqleave_infodesc,
                reqleave_worker_code = obj.reqleave_worker_code,
                reqleave_status = obj.reqleave_status,
                reqleave_cutoff = obj.reqleave_cutoff,
                reqleave_filepath = obj.reqleave_filepath,

                reqleave_reftype = obj.reqleave_reftype,
                reqleave_datetype = obj.reqleave_datetype,
                reqleave_dateqty = obj.reqleave_dateqty,
                reqleave_ihr_ref1 = obj.reqleave_ihr_ref1,
                reqleave_ihr_ref2 = obj.reqleave_ihr_ref2
            };
        }
    }
}
