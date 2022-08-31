using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ISysmtapp_workerDataAccess
    {
        List<Sysmtapp_worker> GetSysmtapp_worker();
        List<Sysmtapp_worker> GetSysmtapp_workerByCode(int code);
        List<Sysmtapp_worker> GetSysmtapp_workerByCodeApp(int code);
        Sysmtapp_worker CreateSysmtapp_worker(Sysmtapp_worker obj);
        Sysmtapp_worker UpdateSysmtapp_worker(Sysmtapp_worker obj);
        void DeleteSysmtapp_worker(int code);
    }
}
