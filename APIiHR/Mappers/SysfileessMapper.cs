using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class SysfileessMapper
    {
        public static Sysfileess MapToCommon(SysfileessDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysfileess
            {
                sysfileess_createdate = obj.sysfileess_createdate,
                sysfileess_txdesc = obj.sysfileess_txdesc,
                sysfileess_worker_code = obj.sysfileess_worker_code,
                sysfileess_refmod = obj.sysfileess_refmod,
                sysfileess_refdim1 = obj.sysfileess_refdim1,
                sysfileess_refdim2 = obj.sysfileess_refdim2,
                sysfileess_refdim3 = obj.sysfileess_refdim3,
                sysfileess_filename = obj.sysfileess_filename,
                sysfileess_filedata = obj.sysfileess_filedata

            };
        }
        public static SysfileessDAL MapToDto(Sysfileess obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new SysfileessDAL
            {
                sysfileess_createdate = obj.sysfileess_createdate,
                sysfileess_txdesc = obj.sysfileess_txdesc,
                sysfileess_worker_code = obj.sysfileess_worker_code,
                sysfileess_refmod = obj.sysfileess_refmod,
                sysfileess_refdim1 = obj.sysfileess_refdim1,
                sysfileess_refdim2 = obj.sysfileess_refdim2,
                sysfileess_refdim3 = obj.sysfileess_refdim3,
                sysfileess_filename = obj.sysfileess_filename,
                sysfileess_filedata = obj.sysfileess_filedata
            };
        }
    }
}
