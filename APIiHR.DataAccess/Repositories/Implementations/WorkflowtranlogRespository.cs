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
    public class WorkflowtranlogRespository : IWorkflowtranlogRespository
    {
        private DbWorkflowtranlogContext _DbWorkflowtranlogContext;
        public WorkflowtranlogRespository(DbWorkflowtranlogContext dbWorkflowtranlogContext)
        {
            _DbWorkflowtranlogContext = dbWorkflowtranlogContext;
        }
        public Workflowtranlog CreateWorkflowtranlog(Workflowtranlog obj)
        {
            obj.workflowtranlog_createdate = DateTime.Now;
            obj.workflowtranlog_modifydate = DateTime.Now;

            _DbWorkflowtranlogContext.WorkflowtranlogTable.Add(obj);
            _DbWorkflowtranlogContext.SaveChanges();
            return obj;
        }

        public void DeleteWorkflowtranlog(int id)
        {

            var items = _DbWorkflowtranlogContext.WorkflowtranlogTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbWorkflowtranlogContext.Remove(items.First());
                _DbWorkflowtranlogContext.SaveChanges();
            }
        }

        public List<Workflowtranlog> GetWorkflowtranlog()
        {
            return _DbWorkflowtranlogContext.WorkflowtranlogTable.ToList();
        }
        public List<Workflowtranlog> GetWorkflowtranlogByCode(string code)
        {
            var items = _DbWorkflowtranlogContext.WorkflowtranlogTable.Where(item => item.workflowtranlog_codeapp == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Workflowtranlog UpdateWorkflowtranlog(Workflowtranlog obj)
        {
            var items = _DbWorkflowtranlogContext.WorkflowtranlogTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Workflowtranlog = items.FirstOrDefault();
            
            Workflowtranlog.workflowtranlog_modifydate = DateTime.Now;
            Workflowtranlog.workflowtranlog_codeapp = obj.workflowtranlog_codeapp;
            Workflowtranlog.workflowtranlog_module = obj.workflowtranlog_module;
            Workflowtranlog.workflowtranlog_txdesc = obj.workflowtranlog_txdesc;
            Workflowtranlog.workflowtranlog_codereq = obj.workflowtranlog_codereq;
            Workflowtranlog.workflowtranlog_status = obj.workflowtranlog_status;

            _DbWorkflowtranlogContext.SaveChanges();
            return Workflowtranlog;
        }
    }
}
