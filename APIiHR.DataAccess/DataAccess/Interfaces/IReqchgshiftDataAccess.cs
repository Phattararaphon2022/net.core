using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface IReqchgshiftDataAccess
    {
        List<Reqchgshift> GetReqchgshift();
        List<Reqchgshift> GetReqchgshiftByCode(string code);
        Reqchgshift CreateReqchgshift(Reqchgshift obj);
        Reqchgshift UpdateReqchgshift(Reqchgshift obj);
        void DeleteReqchgshift(int code);
    }
}
