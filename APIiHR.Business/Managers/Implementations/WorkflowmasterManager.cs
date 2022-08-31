using APIiHR.Business.Managers.Interfaces;
using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Implementations
{
    public class WorkflowmasterManager : IWorkflowmasterManager
    {
        private IWorkflowmasterDataAccess _WorkflowmasterDataAccess;
        public WorkflowmasterManager(IWorkflowmasterDataAccess WorkflowmasterDataAccess)
        {
            _WorkflowmasterDataAccess = WorkflowmasterDataAccess;
        }

        public Workflowmaster CreateWorkflowmaster(Workflowmaster obj)
        {
            return _WorkflowmasterDataAccess.CreateWorkflowmaster(obj);
        }

        public void DeleteWorkflowmaster(int code)
        {
            _WorkflowmasterDataAccess.DeleteWorkflowmaster(code);
        }
        public void DeleteWorkflowmastercode(string code)
        {
            _WorkflowmasterDataAccess.DeleteWorkflowmastercode(code);
        }

        public List<Workflowmaster> GetWorkflowmaster()
        {
            return _WorkflowmasterDataAccess.GetWorkflowmaster();
        }

        public List<Workflowmaster> GetWorkflowmasterByCode(string code)
        {
            return _WorkflowmasterDataAccess.GetWorkflowmasterByCode(code);
        }

        public Workflowmaster UpdateWorkflowmaster(int id, Workflowmaster obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _WorkflowmasterDataAccess.UpdateWorkflowmaster(obj);
        }
    }
}
