using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ISysmttask_linechkDataAccess
    {
        List<Sysmttask_linechk> GetSysmttask_linechk();
        List<Sysmttask_linechk> GetSysmttask_linechkByCode(string code);
        Sysmttask_linechk CreateSysmttask_linechk(Sysmttask_linechk obj);
        Sysmttask_linechk UpdateSysmttask_linechk(Sysmttask_linechk obj);
        void DeleteSysmttask_linechk(int code);
    }
}
