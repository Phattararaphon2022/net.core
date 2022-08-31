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
    public class Sysinfo_contactManager : ISysinfo_contactManager
    {
        private ISysinfo_contactDataAccess _Sysinfo_contactDataAccess;
        public Sysinfo_contactManager(ISysinfo_contactDataAccess Sysinfo_contactDataAccess)
        {
            _Sysinfo_contactDataAccess = Sysinfo_contactDataAccess;
        }

        public Sysinfo_contact CreateSysinfo_contact(Sysinfo_contact obj)
        {
            return _Sysinfo_contactDataAccess.CreateSysinfo_contact(obj);
        }

        public void DeleteSysinfo_contact(int code)
        {
            _Sysinfo_contactDataAccess.DeleteSysinfo_contact(code);
        }

        public List<Sysinfo_contact> GetSysinfo_contact()
        {
            return _Sysinfo_contactDataAccess.GetSysinfo_contact();
        }

        public List<Sysinfo_contact> GetSysinfo_contactByCode(string code)
        {
            return _Sysinfo_contactDataAccess.GetSysinfo_contactByCode(code);
        }

        public Sysinfo_contact UpdateSysinfo_contact(int id, Sysinfo_contact obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _Sysinfo_contactDataAccess.UpdateSysinfo_contact(obj);
        }
    }
}
