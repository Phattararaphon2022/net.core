using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ISysmodulenoDataAccess
    {
        List<Sysmoduleno> GetSysmoduleno();
        List<Sysmoduleno> GetSysmodulenoByCode(string code);
        Sysmoduleno CreateSysmoduleno(Sysmoduleno obj);
        Sysmoduleno UpdateSysmoduleno(Sysmoduleno obj);
        void DeleteSysmoduleno(int code);
    }
}
