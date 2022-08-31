using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface ISysinfo_cardRespository
    {
        List<Sysinfo_card> GetSysinfo_card();
        List<Sysinfo_card> GetSysinfo_cardByCode(string code);

        Sysinfo_card CreateSysinfo_card(Sysinfo_card obj);

        Sysinfo_card UpdateSysinfo_card(Sysinfo_card obj);

        void DeleteSysinfo_card(int id);
    }
}
