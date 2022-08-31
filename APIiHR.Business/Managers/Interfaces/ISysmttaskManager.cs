using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISysmttaskManager
    {
        List<Sysmttask> GetSysmttask();
        List<Sysmttask> GetSysmttaskByCode(string code);
        Sysmttask CreateSysmttask(Sysmttask obj);
        Sysmttask UpdateSysmttask(int id, Sysmttask obj);
        void DeleteSysmttask(int code);
    }
}
