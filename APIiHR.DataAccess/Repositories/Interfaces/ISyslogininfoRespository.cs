using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface ISyslogininfoRespository
    {
        List<Syslogininfo> GetSyslogininfo();
        List<Syslogininfo> GetSyslogininfoByCode(string code);

        Syslogininfo CreateSyslogininfo(Syslogininfo obj);

        Syslogininfo UpdateSyslogininfo(Syslogininfo obj);

        void DeleteSyslogininfo(int id);
    }
}
