using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class WorkflowtranMapper
    {
        public static Workflowtran MapToCommon(WorkflowtranDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Workflowtran
            {
              
                
                workflowtran_createdate = obj.workflowtran_createdate,
                workflowtran_modifydate = obj.workflowtran_modifydate,
                workflowtran_worker_code = obj.workflowtran_worker_code,
                workflowtran_reftype = obj.workflowtran_reftype,
                workflowtran_refmodule = obj.workflowtran_refmodule,
                workflowtran_txdesc = obj.workflowtran_txdesc,
                workflowtran_status = obj.workflowtran_status,
                workflowtran_nextstate = obj.workflowtran_nextstate,
                workflowtran_refworkflowid = obj.workflowtran_refworkflowid,
                workflowtran_appworkid = obj.workflowtran_appworkid,
                workflowtran_txcomm = obj.workflowtran_txcomm,
                workflowtran_nextrecid = obj.workflowtran_nextrecid
            };
        }
        public static WorkflowtranDAL MapToDto(Workflowtran obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new WorkflowtranDAL
            {
               
                workflowtran_createdate = obj.workflowtran_createdate,
                workflowtran_modifydate = obj.workflowtran_modifydate,
                workflowtran_worker_code = obj.workflowtran_worker_code,
                workflowtran_reftype = obj.workflowtran_reftype,
                workflowtran_refmodule = obj.workflowtran_refmodule,
                workflowtran_txdesc = obj.workflowtran_txdesc,
                workflowtran_status = obj.workflowtran_status,
                workflowtran_nextstate = obj.workflowtran_nextstate,
                workflowtran_refworkflowid = obj.workflowtran_refworkflowid,
                workflowtran_appworkid = obj.workflowtran_appworkid,
                workflowtran_txcomm = obj.workflowtran_txcomm,
                workflowtran_nextrecid = obj.workflowtran_nextrecid
            };
        }
    }
}
