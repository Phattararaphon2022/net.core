using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class WorkflowtranlogMapper
    {
        public static Workflowtranlog MapToCommon(WorkflowtranlogDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Workflowtranlog
            {
                
                workflowtranlog_modifydate = obj.workflowtranlog_modifydate,
                workflowtranlog_codeapp = obj.workflowtranlog_codeapp,
                workflowtranlog_module = obj.workflowtranlog_module,
                workflowtranlog_txdesc = obj.workflowtranlog_txdesc,
                workflowtranlog_codereq = obj.workflowtranlog_codereq,
                workflowtranlog_status = obj.workflowtranlog_status

            };
        }
        public static WorkflowtranlogDAL MapToDto(Workflowtranlog obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new WorkflowtranlogDAL
            {
                workflowtranlog_modifydate = obj.workflowtranlog_modifydate,
                workflowtranlog_codeapp = obj.workflowtranlog_codeapp,
                workflowtranlog_module = obj.workflowtranlog_module,
                workflowtranlog_txdesc = obj.workflowtranlog_txdesc,
                workflowtranlog_codereq = obj.workflowtranlog_codereq,
                workflowtranlog_status = obj.workflowtranlog_status
            };
        }
    }
}
