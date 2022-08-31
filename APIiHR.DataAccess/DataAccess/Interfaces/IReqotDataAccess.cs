using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface IReqotDataAccess
    {
        List<Reqot> GetReqot();
        List<Reqot> GetReqotByCode(string code);
        Reqot CreateReqot(Reqot obj);
        Reqot UpdateReqot(Reqot obj);
        void DeleteReqot(int code);
    }
}
