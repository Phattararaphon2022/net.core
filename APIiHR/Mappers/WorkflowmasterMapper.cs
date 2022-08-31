using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class WorkflowmasterMapper
    {
        public static Workflowmaster MapToCommon(WorkflowmasterDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Workflowmaster
            {
                workflowmaster_createdate = obj.workflowmaster_createdate,
                workflowmaster_txdesc = obj.workflowmaster_txdesc,
                workflowmaster_group = obj.workflowmaster_group,
                workflowmaster_refgroup = obj.workflowmaster_refgroup,
                workflowmaster_refdim1 = obj.workflowmaster_refdim1,
                workflowmaster_refdim2 = obj.workflowmaster_refdim2,
                workflowmaster_active = obj.workflowmaster_active,
                workflowmaster_process = obj.workflowmaster_process

            };
        }
        public static WorkflowmasterDAL MapToDto(Workflowmaster obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new WorkflowmasterDAL
            {
                workflowmaster_createdate = obj.workflowmaster_createdate,
                workflowmaster_txdesc = obj.workflowmaster_txdesc,
                workflowmaster_group = obj.workflowmaster_group,
                workflowmaster_refgroup = obj.workflowmaster_refgroup,
                workflowmaster_refdim1 = obj.workflowmaster_refdim1,
                workflowmaster_refdim2 = obj.workflowmaster_refdim2,
                workflowmaster_active = obj.workflowmaster_active,
                workflowmaster_process = obj.workflowmaster_process
            };
        }
    }
}
