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
    public class SysuserempDataAccess : ISysuserempDataAccess
    {
        private ISysuserempRespository _SysuserempRespository;
        public SysuserempDataAccess(ISysuserempRespository SysuserempRepository)
        {
            _SysuserempRespository = SysuserempRepository;
        }
        public Sysuseremp CreateSysuseremp(Sysuseremp obj)
        {
            return _SysuserempRespository.CreateSysuseremp(obj);
        }

        public void DeleteSysuseremp(int code)
        {
            _SysuserempRespository.DeleteSysuseremp(code);
        }

        public List<Sysuseremp> GetSysuseremp()
        {
            return _SysuserempRespository.GetSysuseremp();
        }

        public List<Sysuseremp> GetSysuserempByCode(string code)
        {
            return _SysuserempRespository.GetSysuserempByCode(code);

        }

        public Sysuseremp UpdateSysuseremp(Sysuseremp obj)
        {
            return _SysuserempRespository.UpdateSysuseremp(obj);
        }
    }
}
