using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface IWorkflowmasterRespository
    {
        List<Workflowmaster> GetWorkflowmaster();
        List<Workflowmaster> GetWorkflowmasterByCode(string code);

        Workflowmaster CreateWorkflowmaster(Workflowmaster obj);

        Workflowmaster UpdateWorkflowmaster(Workflowmaster obj);

        void DeleteWorkflowmaster(int id);
        void DeleteWorkflowmastercode(string id);
    }
}
