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
    public class Sysinfo_addDataAccess : ISysinfo_addDataAccess
    {
        private ISysinfo_addRespository _Sysinfo_addRespository;
        public Sysinfo_addDataAccess(ISysinfo_addRespository Sysinfo_addRepository)
        {
            _Sysinfo_addRespository = Sysinfo_addRepository;
        }
        public Sysinfo_add CreateSysinfo_add(Sysinfo_add obj)
        {
            return _Sysinfo_addRespository.CreateSysinfo_add(obj);
        }

        public void DeleteSysinfo_add(int code)
        {
            _Sysinfo_addRespository.DeleteSysinfo_add(code);
        }

        public List<Sysinfo_add> GetSysinfo_add()
        {
            return _Sysinfo_addRespository.GetSysinfo_add();
        }

        public List<Sysinfo_add> GetSysinfo_addByCode(string code)
        {
            return _Sysinfo_addRespository.GetSysinfo_addByCode(code);

        }

        public Sysinfo_add UpdateSysinfo_add(Sysinfo_add obj)
        {
            return _Sysinfo_addRespository.UpdateSysinfo_add(obj);
        }
    }
}
