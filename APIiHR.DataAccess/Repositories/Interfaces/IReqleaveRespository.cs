using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface IReqleaveRespository
    {
        List<Reqleave> GetReqleave();
        List<Reqleave> GetReqleaveByCode(string code);
        Reqleave CreateReqleave(Reqleave obj);
        Reqleave UpdateReqleave(Reqleave obj);
        void DeleteReqleave(int id);
    }
}
