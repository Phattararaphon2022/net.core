using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class SysuserempMapper
    {
        public static Sysuseremp MapToCommon(SysuserempDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysuseremp
            {
                sysuseremp_worker_code = obj.sysuseremp_worker_code,
                sysuseremp_name = obj.sysuseremp_name,
                sysuseremp_status = obj.sysuseremp_status,
                sysuseremp_lock = obj.sysuseremp_lock,
                sysuseremp_pass = obj.sysuseremp_pass,
                sysuseremp_plaintx = obj.sysuseremp_plaintx

            };
        }
        public static SysuserempDAL MapToDto(Sysuseremp obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new SysuserempDAL
            {
                sysuseremp_worker_code = obj.sysuseremp_worker_code,
                sysuseremp_name = obj.sysuseremp_name,
                sysuseremp_status = obj.sysuseremp_status,
                sysuseremp_lock = obj.sysuseremp_lock,
                sysuseremp_pass = obj.sysuseremp_pass,
                sysuseremp_plaintx = obj.sysuseremp_plaintx
            };
        }
    }
}
