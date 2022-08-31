using APIiHR.Common;
using APIiHR.DataAccess.DatabaseContexts;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Implementations
{
    public class Sysmtapp_routeRespository : ISysmtapp_routeRespository
    {
        private DbSysmtapp_routeContext _DbSysmtapp_routeContext;
        public Sysmtapp_routeRespository(DbSysmtapp_routeContext dbSysmtapp_routeContext)
        {
            _DbSysmtapp_routeContext = dbSysmtapp_routeContext;
        }
        public Sysmtapp_route CreateSysmtapp_route(Sysmtapp_route obj)
        {
            obj.recid = new int();
            obj.sysmtapp_route_createdate = DateTime.Now;
            obj.sysmtapp_route_modifydate = DateTime.Now;
            _DbSysmtapp_routeContext.Sysmtapp_routeTable.Add(obj);
            _DbSysmtapp_routeContext.SaveChanges();
            return obj;
        }

        public void DeleteSysmtapp_route(int id)
        {
            var items = _DbSysmtapp_routeContext.Sysmtapp_routeTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysmtapp_routeContext.Remove(items.First());
                _DbSysmtapp_routeContext.SaveChanges();
            }
        }

        public List<Sysmtapp_route> GetSysmtapp_route()
        {
            return _DbSysmtapp_routeContext.Sysmtapp_routeTable.ToList();
        }
        public List<Sysmtapp_route> GetSysmtapp_routeByCode(int code)
        {
            var items = _DbSysmtapp_routeContext.Sysmtapp_routeTable.Where(item => item.sysmtapp_route_refgroup == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysmtapp_route UpdateSysmtapp_route(Sysmtapp_route obj)
        {
            var items = _DbSysmtapp_routeContext.Sysmtapp_routeTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysmtapp_route = items.FirstOrDefault();

            Sysmtapp_route.sysmtapp_route_modifydate = DateTime.Now;
            Sysmtapp_route.sysmtapp_route_refcode = obj.sysmtapp_route_refcode;
            Sysmtapp_route.sysmtapp_route_refrecid = obj.sysmtapp_route_refrecid;
            Sysmtapp_route.sysmtapp_route_nextrefcode = obj.sysmtapp_route_nextrefcode;
            Sysmtapp_route.sysmtapp_route_nextrefrecid = obj.sysmtapp_route_nextrefrecid;
            Sysmtapp_route.sysmtapp_route_status = obj.sysmtapp_route_status;
            Sysmtapp_route.sysmtapp_route_refgroup = obj.sysmtapp_route_refgroup;

            Sysmtapp_route.sysmtapp_route_refgroupcode = obj.sysmtapp_route_refgroupcode;
            Sysmtapp_route.sysmtapp_route_txdesc = obj.sysmtapp_route_txdesc;

            _DbSysmtapp_routeContext.SaveChanges();
            return Sysmtapp_route;
        }
    }
}
