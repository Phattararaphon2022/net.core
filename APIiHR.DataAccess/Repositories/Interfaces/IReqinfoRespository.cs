using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface IReqinfoRespository
    {
        List<Reqinfo> GetReqinfo();
        List<Reqinfo> GetReqinfoByCode(int code);

        Reqinfo CreateReqinfo(Reqinfo obj);

        Reqinfo UpdateReqinfo(Reqinfo obj);

        void DeleteReqinfo(int id);
    }
}
