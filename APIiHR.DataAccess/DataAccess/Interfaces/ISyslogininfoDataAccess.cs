using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ISyslogininfoDataAccess 
    {
        List<Syslogininfo> GetSyslogininfo();
        List<Syslogininfo> GetSyslogininfoByCode(string code);
        Syslogininfo CreateSyslogininfo(Syslogininfo obj);
        Syslogininfo UpdateSyslogininfo(Syslogininfo obj);
        void DeleteSyslogininfo(int code);
    }
}
