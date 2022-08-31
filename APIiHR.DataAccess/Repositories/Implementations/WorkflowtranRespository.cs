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
    class WorkflowtranRespository : IWorkflowtranRespository
    {
        private DbWorkflowtranContext _DbWorkflowtranContext;
        public WorkflowtranRespository(DbWorkflowtranContext dbWorkflowtranContext)
        {
            _DbWorkflowtranContext = dbWorkflowtranContext;
        }
        public Workflowtran CreateWorkflowtran(Workflowtran obj)
        {
            obj.recid = new int();
            obj.workflowtran_createdate = DateTime.Now;
            obj.workflowtran_modifydate = DateTime.Now;
            //obj.recid = 
            //obj.Workflowtran_date = DateTime.Now;
           
            _DbWorkflowtranContext.WorkflowtranTable.Add(obj);
            _DbWorkflowtranContext.SaveChanges();
            return obj;
        }

        public void DeleteWorkflowtran(int id)
        {

            var items = _DbWorkflowtranContext.WorkflowtranTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbWorkflowtranContext.Remove(items.First());
                _DbWorkflowtranContext.SaveChanges();
            }
        }

        public List<Workflowtran> GetWorkflowtran()
        {
            return _DbWorkflowtranContext.WorkflowtranTable.ToList();
        }
        public List<Workflowtran> GetWorkflowtranByCode(int code)
        {

            var items = _DbWorkflowtranContext.WorkflowtranTable.Where(item => item.recid == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Workflowtran UpdateWorkflowtran(Workflowtran obj)
        {
            var items = _DbWorkflowtranContext.WorkflowtranTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Workflowtran = items.FirstOrDefault();

            Workflowtran.workflowtran_modifydate =  DateTime.Now;
            Workflowtran.workflowtran_worker_code = obj.workflowtran_worker_code;
            Workflowtran.workflowtran_reftype = obj.workflowtran_reftype;
            Workflowtran.workflowtran_refmodule = obj.workflowtran_refmodule;
            Workflowtran.workflowtran_txdesc = obj.workflowtran_txdesc;
            Workflowtran.workflowtran_status = obj.workflowtran_status;
            Workflowtran.workflowtran_nextstate = obj.workflowtran_nextstate;
            Workflowtran.workflowtran_refworkflowid = obj.workflowtran_refworkflowid;
            Workflowtran.workflowtran_appworkid = obj.workflowtran_appworkid;
            Workflowtran.workflowtran_txcomm = obj.workflowtran_txcomm;
            Workflowtran.workflowtran_nextrecid = obj.workflowtran_nextrecid;


            _DbWorkflowtranContext.SaveChanges();
            return Workflowtran;
        }
    }
}
