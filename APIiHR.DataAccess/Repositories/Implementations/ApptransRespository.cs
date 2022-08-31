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
    public class ApptransRespository : IApptransRespository
    {
        private DbApptransContext _DbApptransContext;
        public ApptransRespository(DbApptransContext dbApptransContext)
        {
            _DbApptransContext = dbApptransContext;
        }
        public Apptrans CreateApptrans(Apptrans obj)
        {
            obj.recid = new int();
            obj.apptrans_createdate = DateTime.Now;
            obj.apptrans_modifydate = DateTime.Now;
            _DbApptransContext.ApptransTable.Add(obj);
            _DbApptransContext.SaveChanges();
            return obj;
        }

        public void DeleteApptrans(int id)
        {

            var items = _DbApptransContext.ApptransTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbApptransContext.Remove(items.First());
                _DbApptransContext.SaveChanges();
            }
        }

        public List<Apptrans> GetApptrans()
        {
            return _DbApptransContext.ApptransTable.ToList();
        }
        public List<Apptrans> GetApptransByCode(string code)
        {
            var items = _DbApptransContext.ApptransTable.Where(item => item.apptrans_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Apptrans UpdateApptrans(Apptrans obj)
        {
            var items = _DbApptransContext.ApptransTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Apptrans = items.FirstOrDefault();

            Apptrans.apptrans_modifydate = DateTime.Now;
            Apptrans.apptrans_worker_code = obj.apptrans_worker_code;
            Apptrans.apptrans_refapp = obj.apptrans_refapp;
            Apptrans.apptrans_level = obj.apptrans_level;
            Apptrans.apptrans_reqgroup = obj.apptrans_reqgroup;
            Apptrans.apptrans_workerapp_id = obj.apptrans_workerapp_id;
            Apptrans.apptrans_status = obj.apptrans_status;
            Apptrans.apptrans_nmmodule = obj.apptrans_nmmodule;
            Apptrans.apptrans_codemodule = obj.apptrans_codemodule;
            Apptrans.apptrans_appdate = obj.apptrans_appdate;
            Apptrans.apptrans_action = obj.apptrans_action;

            _DbApptransContext.SaveChanges();
            return Apptrans;
        }
    }
}
