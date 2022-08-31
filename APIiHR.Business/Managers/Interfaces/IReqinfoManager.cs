using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IReqinfoManager
    {
        List<Reqinfo> GetReqinfo();
        List<Reqinfo> GetReqinfoByCode(int code);
        Reqinfo CreateReqinfo(Reqinfo obj);
        Reqinfo UpdateReqinfo(int id, Reqinfo obj);
        void DeleteReqinfo(int code);
    }
}
