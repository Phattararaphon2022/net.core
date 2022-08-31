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
    public class Sysinfo_contactDataAccess : ISysinfo_contactDataAccess
    {
        private ISysinfo_contactRespository _Sysinfo_contactRespository;
        public Sysinfo_contactDataAccess(ISysinfo_contactRespository Sysinfo_contactRepository)
        {
            _Sysinfo_contactRespository = Sysinfo_contactRepository;
        }
        public Sysinfo_contact CreateSysinfo_contact(Sysinfo_contact obj)
        {
            return _Sysinfo_contactRespository.CreateSysinfo_contact(obj);
        }

        public void DeleteSysinfo_contact(int code)
        {
            _Sysinfo_contactRespository.DeleteSysinfo_contact(code);
        }

        public List<Sysinfo_contact> GetSysinfo_contact()
        {
            return _Sysinfo_contactRespository.GetSysinfo_contact();
        }

        public List<Sysinfo_contact> GetSysinfo_contactByCode(string code)
        {
            return _Sysinfo_contactRespository.GetSysinfo_contactByCode(code);

        }

        public Sysinfo_contact UpdateSysinfo_contact(Sysinfo_contact obj)
        {
            return _Sysinfo_contactRespository.UpdateSysinfo_contact(obj);
        }
    }
}
