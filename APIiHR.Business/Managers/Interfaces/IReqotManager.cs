using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IReqotManager
    {
        List<Reqot> GetReqot();
        List<Reqot> GetReqotByCode(string code);
        Reqot CreateReqot(Reqot obj);
        Reqot UpdateReqot(int id, Reqot obj);
        void DeleteReqot(int code);
    }
}
