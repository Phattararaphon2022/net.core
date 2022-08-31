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
    public class SysmtappDataAccess : ISysmtappDataAccess
    {
        private ISysmtappRespository _SysmtappRespository;
        public SysmtappDataAccess(ISysmtappRespository SysmtappRepository)
        {
            _SysmtappRespository = SysmtappRepository;
        }
        public Sysmtapp CreateSysmtapp(Sysmtapp obj)
        {

            return _SysmtappRespository.CreateSysmtapp(obj);
        }

        public void DeleteSysmtapp(int code)
        {
            _SysmtappRespository.DeleteSysmtapp(code);
        }

        public List<Sysmtapp> GetSysmtapp()
        {
            return _SysmtappRespository.GetSysmtapp();
        }

        public List<Sysmtapp> GetSysmtappByCode(int code)
        {
            return _SysmtappRespository.GetSysmtappByCode(code);

        }

        public Sysmtapp UpdateSysmtapp(Sysmtapp obj)
        {
            return _SysmtappRespository.UpdateSysmtapp(obj);
        }
    }
}
