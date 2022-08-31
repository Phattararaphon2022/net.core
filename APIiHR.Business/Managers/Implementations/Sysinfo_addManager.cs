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
    public class Sysinfo_addManager : ISysinfo_addManager
    {
        private ISysinfo_addDataAccess _Sysinfo_addDataAccess;
        public Sysinfo_addManager(ISysinfo_addDataAccess Sysinfo_addDataAccess)
        {
            _Sysinfo_addDataAccess = Sysinfo_addDataAccess;
        }

        public Sysinfo_add CreateSysinfo_add(Sysinfo_add obj)
        {
            return _Sysinfo_addDataAccess.CreateSysinfo_add(obj);
        }

        public void DeleteSysinfo_add(int code)
        {
            _Sysinfo_addDataAccess.DeleteSysinfo_add(code);
        }

        public List<Sysinfo_add> GetSysinfo_add()
        {
            return _Sysinfo_addDataAccess.GetSysinfo_add();
        }

        public List<Sysinfo_add> GetSysinfo_addByCode(string code)
        {
            return _Sysinfo_addDataAccess.GetSysinfo_addByCode(code);
        }

        public Sysinfo_add UpdateSysinfo_add(int id, Sysinfo_add obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _Sysinfo_addDataAccess.UpdateSysinfo_add(obj);
        }
    }
}
