using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISysinfo_addManager
    {
        List<Sysinfo_add> GetSysinfo_add();
        List<Sysinfo_add> GetSysinfo_addByCode(string code);
        Sysinfo_add CreateSysinfo_add(Sysinfo_add obj);
        Sysinfo_add UpdateSysinfo_add(int id, Sysinfo_add obj);
        void DeleteSysinfo_add(int code);
    }
}
