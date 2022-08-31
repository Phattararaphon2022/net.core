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
    public class Sysmtapp_workerRespository : ISysmtapp_workerRespository
    {
        private DbSysmtapp_workerContext _DbSysmtapp_workerContext;
        public Sysmtapp_workerRespository(DbSysmtapp_workerContext dbSysmtapp_workerContext)
        {
            _DbSysmtapp_workerContext = dbSysmtapp_workerContext;
        }
        public Sysmtapp_worker CreateSysmtapp_worker(Sysmtapp_worker obj)
        {
            obj.recid = new int();
            obj.sysmtapp_worker_createdate = DateTime.Now;
            //obj.recid = 
            //obj.Sysmtapp_worker_date = DateTime.Now;
           
            _DbSysmtapp_workerContext.Sysmtapp_workerTable.Add(obj);
            _DbSysmtapp_workerContext.SaveChanges();
            return obj;
        }

        public void DeleteSysmtapp_worker(int id)
        {

            var items = _DbSysmtapp_workerContext.Sysmtapp_workerTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysmtapp_workerContext.Remove(items.First());
                _DbSysmtapp_workerContext.SaveChanges();
            }
        }

        public List<Sysmtapp_worker> GetSysmtapp_worker()
        {
            return _DbSysmtapp_workerContext.Sysmtapp_workerTable.ToList();
        }
        public List<Sysmtapp_worker> GetSysmtapp_workerByCodeApp(int code)
        {
            var items = _DbSysmtapp_workerContext.Sysmtapp_workerTable
                    .Where(item => item.sysmtapp_worker_refrecid == code && item.sysmtapp_worker_memtype == "Mng");
                    
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }

        
        public List<Sysmtapp_worker> GetSysmtapp_workerByCode(int code)
        {
            var items = _DbSysmtapp_workerContext.Sysmtapp_workerTable.Where(item => item.sysmtapp_worker_refrecid == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysmtapp_worker UpdateSysmtapp_worker(Sysmtapp_worker obj)
        {
            var items = _DbSysmtapp_workerContext.Sysmtapp_workerTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysmtapp_worker = items.FirstOrDefault();

           
            Sysmtapp_worker.sysmtapp_worker_namealian = obj.sysmtapp_worker_namealian;
            Sysmtapp_worker.sysmtapp_worker_worker_code = obj.sysmtapp_worker_worker_code;
            Sysmtapp_worker.sysmtapp_worker_status = obj.sysmtapp_worker_status;
            Sysmtapp_worker.sysmtapp_worker_refrecid = obj.sysmtapp_worker_refrecid;
            Sysmtapp_worker.sysmtapp_worker_refcode = obj.sysmtapp_worker_refcode;
            Sysmtapp_worker.sysmtapp_worker_memtype = obj.sysmtapp_worker_memtype;
            Sysmtapp_worker.sysmtapp_worker_memalert = obj.sysmtapp_worker_memalert;




            _DbSysmtapp_workerContext.SaveChanges();
            return Sysmtapp_worker;
        }
    }
}
