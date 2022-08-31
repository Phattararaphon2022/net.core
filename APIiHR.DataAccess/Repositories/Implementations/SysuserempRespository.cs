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
    public class SysuserempRespository : ISysuserempRespository
    {
        private DbSysuserempContext _DbSysuserempContext;
        public SysuserempRespository(DbSysuserempContext dbSysuserempContext)
        {
            _DbSysuserempContext = dbSysuserempContext;
        }
        public Sysuseremp CreateSysuseremp(Sysuseremp obj)
        {
            obj.recid = new int();
            obj.sysuseremp_createdate = DateTime.Now;
            obj.sysuseremp_modifydate = DateTime.Now;
            obj.sysuseremp_lock = false;
            _DbSysuserempContext.SysuserempTable.Add(obj);
            _DbSysuserempContext.SaveChanges();
            return obj;
        }

        public void DeleteSysuseremp(int id)
        {

            var items = _DbSysuserempContext.SysuserempTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysuserempContext.Remove(items.First());
                _DbSysuserempContext.SaveChanges();
            }
        }

        public List<Sysuseremp> GetSysuseremp()
        {
            return _DbSysuserempContext.SysuserempTable.ToList();
        }
        public List<Sysuseremp> GetSysuserempByCode(string code)
        {
            var items = _DbSysuserempContext.SysuserempTable.Where(item => item.sysuseremp_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysuseremp UpdateSysuseremp(Sysuseremp obj)
        {
            var items = _DbSysuserempContext.SysuserempTable.Where(item => item.sysuseremp_worker_code == obj.sysuseremp_worker_code);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysuseremp = items.FirstOrDefault();

            Sysuseremp.sysuseremp_modifydate = DateTime.Now;
            Sysuseremp.sysuseremp_status = obj.sysuseremp_status;
            Sysuseremp.sysuseremp_lock = obj.sysuseremp_lock;
            Sysuseremp.sysuseremp_pass = obj.sysuseremp_pass;
            Sysuseremp.sysuseremp_plaintx = obj.sysuseremp_plaintx;

            _DbSysuserempContext.SaveChanges();
            return Sysuseremp;
        }
    }
}
