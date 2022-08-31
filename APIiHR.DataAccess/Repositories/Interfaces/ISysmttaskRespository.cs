using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface ISysmttaskRespository
    {
        List<Sysmttask> GetSysmttask();
        List<Sysmttask> GetSysmttaskByCode(string code);

        Sysmttask CreateSysmttask(Sysmttask obj);

        Sysmttask UpdateSysmttask(Sysmttask obj);

        void DeleteSysmttask(int id);
    }
}
