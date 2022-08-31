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
    public class Sysmtapp_workerDataAccess : ISysmtapp_workerDataAccess
    {
        private ISysmtapp_workerRespository _Sysmtapp_workerRespository;
        public Sysmtapp_workerDataAccess(ISysmtapp_workerRespository Sysmtapp_workerRepository)
        {
            _Sysmtapp_workerRespository = Sysmtapp_workerRepository;
        }
        public Sysmtapp_worker CreateSysmtapp_worker(Sysmtapp_worker obj)
        {
            return _Sysmtapp_workerRespository.CreateSysmtapp_worker(obj);
        }

        public void DeleteSysmtapp_worker(int code)
        {
            _Sysmtapp_workerRespository.DeleteSysmtapp_worker(code);
        }

        public List<Sysmtapp_worker> GetSysmtapp_worker()
        {
            return _Sysmtapp_workerRespository.GetSysmtapp_worker();
        }
        public List<Sysmtapp_worker> GetSysmtapp_workerByCodeApp(int code)
        {
            return _Sysmtapp_workerRespository.GetSysmtapp_workerByCodeApp(code);
        }

        public List<Sysmtapp_worker> GetSysmtapp_workerByCode(int code)
        {
            return _Sysmtapp_workerRespository.GetSysmtapp_workerByCode(code);

        }

        public Sysmtapp_worker UpdateSysmtapp_worker(Sysmtapp_worker obj)
        {
            return _Sysmtapp_workerRespository.UpdateSysmtapp_worker(obj);
        }
    }
}
