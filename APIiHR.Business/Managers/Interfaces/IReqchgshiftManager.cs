using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IReqchgshiftManager
    {
        List<Reqchgshift> GetReqchgshift();
        List<Reqchgshift> GetReqchgshiftByCode(string code);
        Reqchgshift CreateReqchgshift(Reqchgshift obj);
        Reqchgshift UpdateReqchgshift(int id, Reqchgshift obj);
        void DeleteReqchgshift(int code);
    }
}
