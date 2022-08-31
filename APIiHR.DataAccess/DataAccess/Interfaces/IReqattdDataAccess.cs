using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface IReqattdDataAccess
    {
        List<Reqattd> GetReqattd();
        List<Reqattd> GetReqattdByCode(string code);
        Reqattd CreateReqattd(Reqattd obj);
        Reqattd UpdateReqattd(Reqattd obj);
        void DeleteReqattd(int code);
    }
}
