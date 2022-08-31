using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class ApptransMapper
    {
        public static Apptrans MapToCommon(ApptransDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Apptrans
            {
                apptrans_createdate = obj.apptrans_createdate,
                apptrans_modifydate = obj.apptrans_modifydate,
                apptrans_worker_code = obj.apptrans_worker_code,
                apptrans_refapp = obj.apptrans_refapp,
                apptrans_level = obj.apptrans_level,
                apptrans_reqgroup = obj.apptrans_reqgroup,
                apptrans_workerapp_id = obj.apptrans_workerapp_id,
                apptrans_status = obj.apptrans_status,
                apptrans_nmmodule = obj.apptrans_nmmodule,
                apptrans_codemodule = obj.apptrans_codemodule,
                apptrans_appdate = obj.apptrans_appdate,
                apptrans_action = obj.apptrans_action
            };
        }
        public static ApptransDAL MapToDto(Apptrans obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new ApptransDAL
            {
                apptrans_createdate = obj.apptrans_createdate,
                apptrans_modifydate = obj.apptrans_modifydate,
                apptrans_worker_code = obj.apptrans_worker_code,
                apptrans_refapp = obj.apptrans_refapp,
                apptrans_level = obj.apptrans_level,
                apptrans_reqgroup = obj.apptrans_reqgroup,
                apptrans_workerapp_id = obj.apptrans_workerapp_id,
                apptrans_status = obj.apptrans_status,
                apptrans_nmmodule = obj.apptrans_nmmodule,
                apptrans_codemodule = obj.apptrans_codemodule,
                apptrans_appdate = obj.apptrans_appdate,
                apptrans_action = obj.apptrans_action
            };
        }
    }
}
