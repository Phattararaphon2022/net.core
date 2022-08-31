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
    public class Sysmtapp_routeDataAccess : ISysmtapp_routeDataAccess
    {
        private ISysmtapp_routeRespository _Sysmtapp_routeRespository;
        public Sysmtapp_routeDataAccess(ISysmtapp_routeRespository Sysmtapp_routeRepository)
        {
            _Sysmtapp_routeRespository = Sysmtapp_routeRepository;
        }
        public Sysmtapp_route CreateSysmtapp_route(Sysmtapp_route obj)
        {
            return _Sysmtapp_routeRespository.CreateSysmtapp_route(obj);
        }

        public void DeleteSysmtapp_route(int code)
        {
            _Sysmtapp_routeRespository.DeleteSysmtapp_route(code);
        }

        public List<Sysmtapp_route> GetSysmtapp_route()
        {
            return _Sysmtapp_routeRespository.GetSysmtapp_route();
        }

        public List<Sysmtapp_route> GetSysmtapp_routeByCode(int code)
        {
            return _Sysmtapp_routeRespository.GetSysmtapp_routeByCode(code);

        }

        public Sysmtapp_route UpdateSysmtapp_route(Sysmtapp_route obj)
        {
            return _Sysmtapp_routeRespository.UpdateSysmtapp_route(obj);
        }
    }
}
