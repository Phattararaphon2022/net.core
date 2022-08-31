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
    public class Sysmtapp_workerManager : ISysmtapp_workerManager
    {
        private ISysmtapp_workerDataAccess _Sysmtapp_workerDataAccess;
        public Sysmtapp_workerManager(ISysmtapp_workerDataAccess Sysmtapp_workerDataAccess)
        {
            _Sysmtapp_workerDataAccess = Sysmtapp_workerDataAccess;
        }

        public Sysmtapp_worker CreateSysmtapp_worker(Sysmtapp_worker obj)
        {
            return _Sysmtapp_workerDataAccess.CreateSysmtapp_worker(obj);
        }

        public void DeleteSysmtapp_worker(int code)
        {
            _Sysmtapp_workerDataAccess.DeleteSysmtapp_worker(code);
        }

        public List<Sysmtapp_worker> GetSysmtapp_worker()
        {
            return _Sysmtapp_workerDataAccess.GetSysmtapp_worker();
        }

        public List<Sysmtapp_worker> GetSysmtapp_workerByCode(int code)
        {
            return _Sysmtapp_workerDataAccess.GetSysmtapp_workerByCode(code);
        }
        public List<Sysmtapp_worker> GetSysmtapp_workerByCodeApp(int code)
        {
            return _Sysmtapp_workerDataAccess.GetSysmtapp_workerByCodeApp(code);
        }

        public Sysmtapp_worker UpdateSysmtapp_worker(int id, Sysmtapp_worker obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _Sysmtapp_workerDataAccess.UpdateSysmtapp_worker(obj);
        }
    }
}
