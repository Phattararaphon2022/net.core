using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class SyslocationMapper
    {
        public static Syslocation MapToCommon(SyslocationDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Syslocation
            {
                recid = obj.recid,
                syslocation_createdate = obj.syslocation_createdate,
                syslocation_modifydate = obj.syslocation_modifydate,
                syslocation_name = obj.syslocation_name,
                syslocation_txcomm = obj.syslocation_txcomm,
                syslocation_code = obj.syslocation_code,
                syslocation_status = obj.syslocation_status

            };
        }
        public static SyslocationDAL MapToDto(Syslocation obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new SyslocationDAL
            {
                recid = obj.recid,
                syslocation_createdate = obj.syslocation_createdate,
                syslocation_modifydate = obj.syslocation_modifydate,
                syslocation_name = obj.syslocation_name,
                syslocation_txcomm = obj.syslocation_txcomm,
                syslocation_code = obj.syslocation_code,
                syslocation_status = obj.syslocation_status
            };
        }
    }
}
