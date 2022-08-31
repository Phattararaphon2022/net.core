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
    public class SyslogininfoDataAccess : ISyslogininfoDataAccess
    {
        private ISyslogininfoRespository _SyslogininfoRespository;
        public SyslogininfoDataAccess(ISyslogininfoRespository SyslogininfoRepository)
        {
            _SyslogininfoRespository = SyslogininfoRepository;
        }
        public Syslogininfo CreateSyslogininfo(Syslogininfo obj)
        {
            return _SyslogininfoRespository.CreateSyslogininfo(obj);
        }

        public void DeleteSyslogininfo(int code)
        {
            _SyslogininfoRespository.DeleteSyslogininfo(code);
        }

        public List<Syslogininfo> GetSyslogininfo()
        {
            return _SyslogininfoRespository.GetSyslogininfo();
        }

        public List<Syslogininfo> GetSyslogininfoByCode(string code)
        {
            return _SyslogininfoRespository.GetSyslogininfoByCode(code);

        }

        public Syslogininfo UpdateSyslogininfo(Syslogininfo obj)
        {
            return _SyslogininfoRespository.UpdateSyslogininfo(obj);
        }
    }
}
