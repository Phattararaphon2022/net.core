using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISysuserempManager
    {
        List<Sysuseremp> GetSysuseremp();
        List<Sysuseremp> GetSysuserempByCode(string code);
        Sysuseremp CreateSysuseremp(Sysuseremp obj);
        Sysuseremp UpdateSysuseremp(int id, Sysuseremp obj);
        void DeleteSysuseremp(int code);
    }
}
