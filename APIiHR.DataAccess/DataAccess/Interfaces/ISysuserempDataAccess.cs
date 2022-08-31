using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ISysuserempDataAccess
    {
        List<Sysuseremp> GetSysuseremp();
        List<Sysuseremp> GetSysuserempByCode(string code);
        Sysuseremp CreateSysuseremp(Sysuseremp obj);
        Sysuseremp UpdateSysuseremp(Sysuseremp obj);
        void DeleteSysuseremp(int code);
    }
}
