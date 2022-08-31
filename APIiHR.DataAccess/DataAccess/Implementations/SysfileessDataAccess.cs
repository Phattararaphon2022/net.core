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
    public class SysfileessDataAccess : ISysfileessDataAccess
    {
        private ISysfileessRespository _SysfileessRespository;
        public SysfileessDataAccess(ISysfileessRespository SysfileessRepository)
        {
            _SysfileessRespository = SysfileessRepository;
        }
        public Sysfileess CreateSysfileess(Sysfileess obj)
        {
            return _SysfileessRespository.CreateSysfileess(obj);
        }

        public void DeleteSysfileess(int code)
        {
            _SysfileessRespository.DeleteSysfileess(code);
        }

        public List<Sysfileess> GetSysfileess()
        {
            return _SysfileessRespository.GetSysfileess();
        }

        public List<Sysfileess> GetSysfileessByCode(int code)
        {
            return _SysfileessRespository.GetSysfileessByCode(code);

        }

        public Sysfileess UpdateSysfileess(Sysfileess obj)
        {
            return _SysfileessRespository.UpdateSysfileess(obj);
        }
    }
}
