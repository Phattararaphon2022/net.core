using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ISysinfo_contactDataAccess
    {
        List<Sysinfo_contact> GetSysinfo_contact();
        List<Sysinfo_contact> GetSysinfo_contactByCode(string code);
        Sysinfo_contact CreateSysinfo_contact(Sysinfo_contact obj);
        Sysinfo_contact UpdateSysinfo_contact(Sysinfo_contact obj);
        void DeleteSysinfo_contact(int code);
    }
}
