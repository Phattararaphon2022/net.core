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
    public class SysfileessManager : ISysfileessManager
    {
        private ISysfileessDataAccess _SysfileessDataAccess;
        public SysfileessManager(ISysfileessDataAccess SysfileessDataAccess)
        {
            _SysfileessDataAccess = SysfileessDataAccess;
        }

        public Sysfileess CreateSysfileess(Sysfileess obj)
        {
            return _SysfileessDataAccess.CreateSysfileess(obj);
        }

        public void DeleteSysfileess(int code)
        {
            _SysfileessDataAccess.DeleteSysfileess(code);
        }

        public List<Sysfileess> GetSysfileess()
        {
            return _SysfileessDataAccess.GetSysfileess();
        }

        public List<Sysfileess> GetSysfileessByCode(int code)
        {
            return _SysfileessDataAccess.GetSysfileessByCode(code);
        }

        public Sysfileess UpdateSysfileess(int id, Sysfileess obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _SysfileessDataAccess.UpdateSysfileess(obj);
        }
    }
}
