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
    public class ReqchgshiftDataAccess : IReqchgshiftDataAccess
    {
        private IReqchgshiftRespository _ReqchgshiftRespository;
        public ReqchgshiftDataAccess(IReqchgshiftRespository ReqchgshiftRepository)
        {
            _ReqchgshiftRespository = ReqchgshiftRepository;
        }
        public Reqchgshift CreateReqchgshift(Reqchgshift obj)
        {
            return _ReqchgshiftRespository.CreateReqchgshift(obj);
        }

        public void DeleteReqchgshift(int code)
        {
            _ReqchgshiftRespository.DeleteReqchgshift(code);
        }

        public List<Reqchgshift> GetReqchgshift()
        {
            return _ReqchgshiftRespository.GetReqchgshift();
        }

        public List<Reqchgshift> GetReqchgshiftByCode(string code)
        {
            return _ReqchgshiftRespository.GetReqchgshiftByCode(code);

        }

        public Reqchgshift UpdateReqchgshift(Reqchgshift obj)
        {
            return _ReqchgshiftRespository.UpdateReqchgshift(obj);
        }
    }
}
