using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISysmtapp_routeManager
    {
        List<Sysmtapp_route> GetSysmtapp_route();
        List<Sysmtapp_route> GetSysmtapp_routeByCode(int code);
        Sysmtapp_route CreateSysmtapp_route(Sysmtapp_route obj);
        Sysmtapp_route UpdateSysmtapp_route(int id, Sysmtapp_route obj);
        void DeleteSysmtapp_route(int code);
    }
}

