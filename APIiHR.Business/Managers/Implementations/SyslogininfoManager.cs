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
    public class SyslogininfoManager : ISyslogininfoManager
    {
        private ISyslogininfoDataAccess _SyslogininfoDataAccess;
        public SyslogininfoManager(ISyslogininfoDataAccess SyslogininfoDataAccess)
        {
            _SyslogininfoDataAccess = SyslogininfoDataAccess;
        }

        public Syslogininfo CreateSyslogininfo(Syslogininfo obj)
        {
            return _SyslogininfoDataAccess.CreateSyslogininfo(obj);
        }

        public void DeleteSyslogininfo(int code)
        {
            _SyslogininfoDataAccess.DeleteSyslogininfo(code);
        }

        public List<Syslogininfo> GetSyslogininfo()
        {
            return _SyslogininfoDataAccess.GetSyslogininfo();
        }

        public List<Syslogininfo> GetSyslogininfoByCode(string code)
        {
            return _SyslogininfoDataAccess.GetSyslogininfoByCode(code);
        }

        public Syslogininfo UpdateSyslogininfo(int id, Syslogininfo obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _SyslogininfoDataAccess.UpdateSyslogininfo(obj);
        }
    }
}
