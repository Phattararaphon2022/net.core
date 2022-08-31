using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface ISysuserempRespository
    {
        List<Sysuseremp> GetSysuseremp();
        List<Sysuseremp> GetSysuserempByCode(string code);

        Sysuseremp CreateSysuseremp(Sysuseremp obj);

        Sysuseremp UpdateSysuseremp(Sysuseremp obj);

        void DeleteSysuseremp(int id);
    }
}
