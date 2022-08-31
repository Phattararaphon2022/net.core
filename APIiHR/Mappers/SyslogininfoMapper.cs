using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class SyslogininfoMapper
    {
        public static Syslogininfo MapToCommon(SyslogininfoDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Syslogininfo
            {
                syslogininfo_type = obj.syslogininfo_type,
                syslogininfo_txt = obj.syslogininfo_txt,
                syslogininfo_worker_code = obj.syslogininfo_worker_code,
                syslogininfo_startdate = obj.syslogininfo_startdate,
                syslogininfo_enddate = obj.syslogininfo_enddate,
                syslogininfo_status = obj.syslogininfo_status

            };
        }
        public static SyslogininfoDAL MapToDto(Syslogininfo obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new SyslogininfoDAL
            {
                syslogininfo_type = obj.syslogininfo_type,
                syslogininfo_txt = obj.syslogininfo_txt,
                syslogininfo_worker_code = obj.syslogininfo_worker_code,
                syslogininfo_startdate = obj.syslogininfo_startdate,
                syslogininfo_enddate = obj.syslogininfo_enddate,
                syslogininfo_status = obj.syslogininfo_status
            };
        }
    }
}
