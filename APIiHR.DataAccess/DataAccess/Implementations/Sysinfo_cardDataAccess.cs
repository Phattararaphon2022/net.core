using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Implementations
{
    public class Sysinfo_cardDataAccess : ISysinfo_cardDataAccess
    {
        private ISysinfo_cardRespository _Sysinfo_cardRespository;
        public Sysinfo_cardDataAccess(ISysinfo_cardRespository Sysinfo_cardRepository)
        {
            _Sysinfo_cardRespository = Sysinfo_cardRepository;
        }
        public Sysinfo_card CreateSysinfo_card(Sysinfo_card obj)
        {
            return _Sysinfo_cardRespository.CreateSysinfo_card(obj);
        }

        public void DeleteSysinfo_card(int code)
        {
            _Sysinfo_cardRespository.DeleteSysinfo_card(code);
        }

        public List<Sysinfo_card> GetSysinfo_card()
        {
            return _Sysinfo_cardRespository.GetSysinfo_card();
        }

        public List<Sysinfo_card> GetSysinfo_cardByCode(string code)
        {
            return _Sysinfo_cardRespository.GetSysinfo_cardByCode(code);

        }

        public Sysinfo_card UpdateSysinfo_card(Sysinfo_card obj)
        {
            return _Sysinfo_cardRespository.UpdateSysinfo_card(obj);
        }
    }
}
