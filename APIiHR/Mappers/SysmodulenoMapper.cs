using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class SysmodulenoMapper
    {
        public static Sysmoduleno MapToCommon(SysmodulenoDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmoduleno
            {
                recid = obj.recid,
                sysmoduleno_createdate = obj.sysmoduleno_createdate,
                sysmoduleno_modifydate = obj.sysmoduleno_modifydate,
                sysmoduleno_code = obj.sysmoduleno_code,
                sysmoduleno_name = obj.sysmoduleno_name,
                sysmoduleno_refname = obj.sysmoduleno_refname,
                sysmoduleno_txdesc = obj.sysmoduleno_txdesc,
                sysmoduleno_status = obj.sysmoduleno_status,
                sysmoduleno_codeold = obj.sysmoduleno_codeold
            };
        }
        public static SysmodulenoDAL MapToDto(Sysmoduleno obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new SysmodulenoDAL
            {
                recid = obj.recid,
                sysmoduleno_createdate = obj.sysmoduleno_createdate,
                sysmoduleno_modifydate = obj.sysmoduleno_modifydate,
                sysmoduleno_code = obj.sysmoduleno_code,
                sysmoduleno_name = obj.sysmoduleno_name,
                sysmoduleno_refname = obj.sysmoduleno_refname,
                sysmoduleno_txdesc = obj.sysmoduleno_txdesc,
                sysmoduleno_status = obj.sysmoduleno_status,
                sysmoduleno_codeold = obj.sysmoduleno_codeold
            };
        }
    }
}
