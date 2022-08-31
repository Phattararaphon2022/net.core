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
    public class SysmodulenoDataAccess : ISysmodulenoDataAccess
    {
        private ISysmodulenoRespository _SysmodulenoRespository;
        public SysmodulenoDataAccess(ISysmodulenoRespository SysmodulenoRepository)
        {
            _SysmodulenoRespository = SysmodulenoRepository;
        }
        public Sysmoduleno CreateSysmoduleno(Sysmoduleno obj)
        {
            return _SysmodulenoRespository.CreateSysmoduleno(obj);
        }

        public void DeleteSysmoduleno(int code)
        {
            _SysmodulenoRespository.DeleteSysmoduleno(code);
        }

        public List<Sysmoduleno> GetSysmoduleno()
        {
            return _SysmodulenoRespository.GetSysmoduleno();
        }

        public List<Sysmoduleno> GetSysmodulenoByCode(string code)
        {
            return _SysmodulenoRespository.GetSysmodulenoByCode(code);

        }

        public Sysmoduleno UpdateSysmoduleno(Sysmoduleno obj)
        {
            return _SysmodulenoRespository.UpdateSysmoduleno(obj);
        }
    }
}
