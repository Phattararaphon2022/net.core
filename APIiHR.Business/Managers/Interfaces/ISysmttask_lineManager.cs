using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISysmttask_lineManager
    {
        List<Sysmttask_line> GetSysmttask_line();
        List<Sysmttask_line> GetSysmttask_lineByCode(string code);
        Sysmttask_line CreateSysmttask_line(Sysmttask_line obj);
        Sysmttask_line UpdateSysmttask_line(int id, Sysmttask_line obj);
        void DeleteSysmttask_line(int code);
    }
}
