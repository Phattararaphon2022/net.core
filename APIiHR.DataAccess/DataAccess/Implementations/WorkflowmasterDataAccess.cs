using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Implementations
{
    public class WorkflowmasterDataAccess : IWorkflowmasterDataAccess
    {
        private IWorkflowmasterRespository _WorkflowmasterRespository;
        public WorkflowmasterDataAccess(IWorkflowmasterRespository WorkflowmasterRepository)
        {
            _WorkflowmasterRespository = WorkflowmasterRepository;
        }
        public Workflowmaster CreateWorkflowmaster(Workflowmaster obj)
        {
            return _WorkflowmasterRespository.CreateWorkflowmaster(obj);
        }

        public void DeleteWorkflowmaster(int code)
        {
            _WorkflowmasterRespository.DeleteWorkflowmaster(code);
        }
        public void DeleteWorkflowmastercode(string code)
        {
            _WorkflowmasterRespository.DeleteWorkflowmastercode(code);
        }

        public List<Workflowmaster> GetWorkflowmaster()
        {
            return _WorkflowmasterRespository.GetWorkflowmaster();
        }

        public List<Workflowmaster> GetWorkflowmasterByCode(string code)
        {
            return _WorkflowmasterRespository.GetWorkflowmasterByCode(code);

        }

        public Workflowmaster UpdateWorkflowmaster(Workflowmaster obj)
        {
            return _WorkflowmasterRespository.UpdateWorkflowmaster(obj);
        }
    }
}
