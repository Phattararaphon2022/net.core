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
    public class SysfileessRespository : ISysfileessRespository
    {
        private DbSysfileessContext _DbSysfileessContext;
        public SysfileessRespository(DbSysfileessContext dbSysfileessContext)
        {
            _DbSysfileessContext = dbSysfileessContext;
        }
        public Sysfileess CreateSysfileess(Sysfileess obj)
        {
            obj.recid = new int();
            obj.sysfileess_createdate = DateTime.Now;
            //obj.recid = 
            //obj.Sysfileess_date = DateTime.Now;            
            _DbSysfileessContext.SysfileessTable.Add(obj);
            _DbSysfileessContext.SaveChanges();
            return obj;
        }

        public void DeleteSysfileess(int id)
        {

            var items = _DbSysfileessContext.SysfileessTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysfileessContext.Remove(items.First());
                _DbSysfileessContext.SaveChanges();
            }
        }

        public List<Sysfileess> GetSysfileess()
        {
            return _DbSysfileessContext.SysfileessTable.ToList();
        }
        public List<Sysfileess> GetSysfileessByCode(int code)
        {
            var items = _DbSysfileessContext.SysfileessTable.Where(item => item.recid == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysfileess UpdateSysfileess(Sysfileess obj)
        {
            var items = _DbSysfileessContext.SysfileessTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysfileess = items.FirstOrDefault();

            Sysfileess.sysfileess_createdate = DateTime.Now;
            Sysfileess.sysfileess_txdesc = obj.sysfileess_txdesc;
            Sysfileess.sysfileess_worker_code = obj.sysfileess_worker_code;
            Sysfileess.sysfileess_refmod = obj.sysfileess_refmod;
            Sysfileess.sysfileess_refdim1 = obj.sysfileess_refdim1;
            Sysfileess.sysfileess_refdim2 = obj.sysfileess_refdim2;
            Sysfileess.sysfileess_refdim3 = obj.sysfileess_refdim3;
            Sysfileess.sysfileess_filename = obj.sysfileess_filename;
            Sysfileess.sysfileess_filedata = obj.sysfileess_filedata;

            _DbSysfileessContext.SaveChanges();
            return Sysfileess;
        }
    }
}
