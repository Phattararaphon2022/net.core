using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISyslogininfoManager
    {
        List<Syslogininfo> GetSyslogininfo();
        List<Syslogininfo> GetSyslogininfoByCode(string code);
        Syslogininfo CreateSyslogininfo(Syslogininfo obj);
        Syslogininfo UpdateSyslogininfo(int id, Syslogininfo obj);
        void DeleteSyslogininfo(int code);
    }
}
