using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISysmodulenoManager
    {
        List<Sysmoduleno> GetSysmoduleno();
        List<Sysmoduleno> GetSysmodulenoByCode(string code);
        Sysmoduleno CreateSysmoduleno(Sysmoduleno obj);
        Sysmoduleno UpdateSysmoduleno(int id, Sysmoduleno obj);
        void DeleteSysmoduleno(int code);
    }
}
