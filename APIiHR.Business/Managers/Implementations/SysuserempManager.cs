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
    public class SysuserempManager : ISysuserempManager
    {
        private ISysuserempDataAccess _SysuserempDataAccess;
        public SysuserempManager(ISysuserempDataAccess SysuserempDataAccess)
        {
            _SysuserempDataAccess = SysuserempDataAccess;
        }

        public Sysuseremp CreateSysuseremp(Sysuseremp obj)
        {
            return _SysuserempDataAccess.CreateSysuseremp(obj);
        }

        public void DeleteSysuseremp(int code)
        {
            _SysuserempDataAccess.DeleteSysuseremp(code);
        }

        public List<Sysuseremp> GetSysuseremp()
        {
            return _SysuserempDataAccess.GetSysuseremp();
        }

        public List<Sysuseremp> GetSysuserempByCode(string code)
        {
            return _SysuserempDataAccess.GetSysuserempByCode(code);
        }

        public Sysuseremp UpdateSysuseremp(int id, Sysuseremp obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _SysuserempDataAccess.UpdateSysuseremp(obj);
        }
    }
}
