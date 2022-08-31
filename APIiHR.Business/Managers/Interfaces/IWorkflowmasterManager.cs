using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IWorkflowmasterManager
    {
        List<Workflowmaster> GetWorkflowmaster();
        List<Workflowmaster> GetWorkflowmasterByCode(string code);
        Workflowmaster CreateWorkflowmaster(Workflowmaster obj);
        Workflowmaster UpdateWorkflowmaster(int id, Workflowmaster obj);
        void DeleteWorkflowmaster(int code);
        void DeleteWorkflowmastercode(string code);
    }
}

