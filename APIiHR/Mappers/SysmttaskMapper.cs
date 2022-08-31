using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class SysmttaskMapper
    {
        public static Sysmttask MapToCommon(SysmttaskDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmttask
            {
                recid = obj.recid,
                sysmttask_createdate = obj.sysmttask_createdate,
                sysmttask_namealian = obj.sysmttask_namealian,
                sysmttask_txdesc = obj.sysmttask_txdesc,
                sysmttask_status = obj.sysmttask_status,
                sysmttask_code = obj.sysmttask_code,
                sysmttask_level = obj.sysmttask_level,
                sysmttask_refdim1 = obj.sysmttask_refdim1,
                sysmttask_refdim2 = obj.sysmttask_refdim2

            };
        }
        public static SysmttaskDAL MapToDto(Sysmttask obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new SysmttaskDAL
            {
                recid = obj.recid,
                sysmttask_createdate = obj.sysmttask_createdate,
                sysmttask_namealian = obj.sysmttask_namealian,
                sysmttask_txdesc = obj.sysmttask_txdesc,
                sysmttask_status = obj.sysmttask_status,
                sysmttask_code = obj.sysmttask_code,
                sysmttask_level = obj.sysmttask_level,
                sysmttask_refdim1 = obj.sysmttask_refdim1,
                sysmttask_refdim2 = obj.sysmttask_refdim2

            };
        }
    }
}
