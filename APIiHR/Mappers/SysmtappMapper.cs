using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class SysmtappMapper
    {
        public static Sysmtapp MapToCommon(SysmtappDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmtapp
            {
                recid = obj.recid,
                sysmtapp_createdate = obj.sysmtapp_createdate,
                sysmtapp_namealian = obj.sysmtapp_namealian,
                sysmtapp_txdesc = obj.sysmtapp_txdesc,
                sysmtapp_status = obj.sysmtapp_status,
                sysmtapp_code = obj.sysmtapp_code,
                sysmtapp_nextmt = obj.sysmtapp_nextmt,
                sysmtapp_master = obj.sysmtapp_master,
                sysmtapp_nextmtrec = obj.sysmtapp_nextmtrec


            };
        }
        public static SysmtappDAL MapToDto(Sysmtapp obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new SysmtappDAL
            {
                recid = obj.recid,
                sysmtapp_createdate = obj.sysmtapp_createdate,
                sysmtapp_namealian = obj.sysmtapp_namealian,
                sysmtapp_txdesc = obj.sysmtapp_txdesc,
                sysmtapp_status = obj.sysmtapp_status,
                sysmtapp_code = obj.sysmtapp_code,
                sysmtapp_master = obj.sysmtapp_master,
                sysmtapp_nextmt = obj.sysmtapp_nextmt,
                sysmtapp_nextmtrec = obj.sysmtapp_nextmtrec


            };
        }
    }
}
