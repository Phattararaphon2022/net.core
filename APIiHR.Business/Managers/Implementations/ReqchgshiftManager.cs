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
    public class ReqchgshiftManager : IReqchgshiftManager
    {
        private IReqchgshiftDataAccess _ReqchgshiftDataAccess;
        public ReqchgshiftManager(IReqchgshiftDataAccess ReqchgshiftDataAccess)
        {
            _ReqchgshiftDataAccess = ReqchgshiftDataAccess;
        }

        public Reqchgshift CreateReqchgshift(Reqchgshift obj)
        {
            return _ReqchgshiftDataAccess.CreateReqchgshift(obj);
        }

        public void DeleteReqchgshift(int code)
        {
            _ReqchgshiftDataAccess.DeleteReqchgshift(code);
        }

        public List<Reqchgshift> GetReqchgshift()
        {
            return _ReqchgshiftDataAccess.GetReqchgshift();
        }

        public List<Reqchgshift> GetReqchgshiftByCode(string code)
        {
            return _ReqchgshiftDataAccess.GetReqchgshiftByCode(code);
        }

        public Reqchgshift UpdateReqchgshift(int id, Reqchgshift obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _ReqchgshiftDataAccess.UpdateReqchgshift(obj);
        }
    }
}
