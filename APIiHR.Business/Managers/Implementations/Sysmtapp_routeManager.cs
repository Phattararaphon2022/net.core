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
    public class Sysmtapp_routeManager : ISysmtapp_routeManager
    {
        private ISysmtapp_routeDataAccess _Sysmtapp_routeDataAccess;
        public Sysmtapp_routeManager(ISysmtapp_routeDataAccess Sysmtapp_routeDataAccess)
        {
            _Sysmtapp_routeDataAccess = Sysmtapp_routeDataAccess;
        }

        public Sysmtapp_route CreateSysmtapp_route(Sysmtapp_route obj)
        {
            return _Sysmtapp_routeDataAccess.CreateSysmtapp_route(obj);
        }

        public void DeleteSysmtapp_route(int code)
        {
            _Sysmtapp_routeDataAccess.DeleteSysmtapp_route(code);
        }

        public List<Sysmtapp_route> GetSysmtapp_route()
        {
            return _Sysmtapp_routeDataAccess.GetSysmtapp_route();
        }

        public List<Sysmtapp_route> GetSysmtapp_routeByCode(int code)
        {
            return _Sysmtapp_routeDataAccess.GetSysmtapp_routeByCode(code);
        }

        public Sysmtapp_route UpdateSysmtapp_route(int id, Sysmtapp_route obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _Sysmtapp_routeDataAccess.UpdateSysmtapp_route(obj);
        }
    }
}
