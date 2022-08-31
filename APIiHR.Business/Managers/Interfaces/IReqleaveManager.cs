using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IReqleaveManager
    {
        List<Reqleave> GetReqleave();
        List<Reqleave> GetReqleaveByCode(string code);
        Reqleave CreateReqleave(Reqleave obj);
        Reqleave UpdateReqleave(int id, Reqleave obj);
        void DeleteReqleave(int code);
    }
}
