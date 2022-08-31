using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class Sysmtapp_workerMapper
    {
        public static Sysmtapp_worker MapToCommon(Sysmtapp_workerDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmtapp_worker
            {
                sysmtapp_worker_createdate = obj.sysmtapp_worker_createdate,
                sysmtapp_worker_namealian = obj.sysmtapp_worker_namealian,
                sysmtapp_worker_worker_code = obj.sysmtapp_worker_worker_code,
                sysmtapp_worker_status = obj.sysmtapp_worker_status,
                sysmtapp_worker_refrecid = obj.sysmtapp_worker_refrecid,
                sysmtapp_worker_refcode = obj.sysmtapp_worker_refcode,
                sysmtapp_worker_memtype = obj.sysmtapp_worker_memtype,
                sysmtapp_worker_memalert = obj.sysmtapp_worker_memalert

            };
        }
        public static Sysmtapp_workerDAL MapToDto(Sysmtapp_worker obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmtapp_workerDAL
            {
                sysmtapp_worker_createdate = obj.sysmtapp_worker_createdate,
                sysmtapp_worker_namealian = obj.sysmtapp_worker_namealian,
                sysmtapp_worker_worker_code = obj.sysmtapp_worker_worker_code,
                sysmtapp_worker_status = obj.sysmtapp_worker_status,
                sysmtapp_worker_refrecid = obj.sysmtapp_worker_refrecid,
                sysmtapp_worker_refcode = obj.sysmtapp_worker_refcode,
                sysmtapp_worker_memtype = obj.sysmtapp_worker_memtype,
                sysmtapp_worker_memalert = obj.sysmtapp_worker_memalert
            };
        }
    }
}
