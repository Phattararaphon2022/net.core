using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IReqattdManager
    {
        List<Reqattd> GetReqattd();
        List<Reqattd> GetReqattdByCode(string code);
        Reqattd CreateReqattd(Reqattd obj);
        Reqattd UpdateReqattd(int id, Reqattd obj);
        void DeleteReqattd(int code);
    }
}
