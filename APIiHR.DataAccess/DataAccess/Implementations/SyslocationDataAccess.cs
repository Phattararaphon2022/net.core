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
    public class SyslocationDataAccess : ISyslocationDataAccess
    {
        private ISyslocationRespository _SyslocationRespository;
        public SyslocationDataAccess(ISyslocationRespository SyslocationRepository)
        {
            _SyslocationRespository = SyslocationRepository;
        }
        public Syslocation CreateSyslocation(Syslocation obj)
        {
            return _SyslocationRespository.CreateSyslocation(obj);
        }

        public void DeleteSyslocation(int code)
        {
            _SyslocationRespository.DeleteSyslocation(code);
        }

        public List<Syslocation> GetSyslocation()
        {
            return _SyslocationRespository.GetSyslocation();
        }

        public List<Syslocation> GetSyslocationByCode(string code)
        {
            return _SyslocationRespository.GetSyslocationByCode(code);

        }

        public Syslocation UpdateSyslocation(Syslocation obj)
        {
            return _SyslocationRespository.UpdateSyslocation(obj);
        }
    }
}
