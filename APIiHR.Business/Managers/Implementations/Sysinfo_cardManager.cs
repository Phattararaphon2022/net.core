using APIiHR.Business.Managers.Interfaces;
using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Implementations
{
    public class Sysinfo_cardManager : ISysinfo_cardManager
    {
        private ISysinfo_cardDataAccess _Sysinfo_cardDataAccess;
        public Sysinfo_cardManager(ISysinfo_cardDataAccess Sysinfo_cardDataAccess)
        {
            _Sysinfo_cardDataAccess = Sysinfo_cardDataAccess;
        }

        public Sysinfo_card CreateSysinfo_card(Sysinfo_card obj)
        {
            return _Sysinfo_cardDataAccess.CreateSysinfo_card(obj);
        }

        public void DeleteSysinfo_card(int code)
        {
            _Sysinfo_cardDataAccess.DeleteSysinfo_card(code);
        }

        public List<Sysinfo_card> GetSysinfo_card()
        {
            return _Sysinfo_cardDataAccess.GetSysinfo_card();
        }

        public List<Sysinfo_card> GetSysinfo_cardByCode(string code)
        {
            return _Sysinfo_cardDataAccess.GetSysinfo_cardByCode(code);
        }

        public Sysinfo_card UpdateSysinfo_card(int id, Sysinfo_card obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _Sysinfo_cardDataAccess.UpdateSysinfo_card(obj);
        }
    }
}
