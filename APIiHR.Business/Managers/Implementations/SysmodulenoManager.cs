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
    public class SysmodulenoManager : ISysmodulenoManager
    {
        private ISysmodulenoDataAccess _SysmodulenoDataAccess;
        public SysmodulenoManager(ISysmodulenoDataAccess SysmodulenoDataAccess)
        {
            _SysmodulenoDataAccess = SysmodulenoDataAccess;
        }

        public Sysmoduleno CreateSysmoduleno(Sysmoduleno obj)
        {
            return _SysmodulenoDataAccess.CreateSysmoduleno(obj);
        }

        public void DeleteSysmoduleno(int code)
        {
            _SysmodulenoDataAccess.DeleteSysmoduleno(code);
        }

        public List<Sysmoduleno> GetSysmoduleno()
        {
            return _SysmodulenoDataAccess.GetSysmoduleno();
        }

        public List<Sysmoduleno> GetSysmodulenoByCode(string code)
        {
            return _SysmodulenoDataAccess.GetSysmodulenoByCode(code);
        }

        public Sysmoduleno UpdateSysmoduleno(int id, Sysmoduleno obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _SysmodulenoDataAccess.UpdateSysmoduleno(obj);
        }
    }
}
