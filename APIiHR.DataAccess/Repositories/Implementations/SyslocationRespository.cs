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
    public  class SyslocationRespository : ISyslocationRespository
    {
        private DbSyslocationContext _DbSyslocationContext;
        public SyslocationRespository(DbSyslocationContext dbSyslocationContext)
        {
            _DbSyslocationContext = dbSyslocationContext;
        }
        public Syslocation CreateSyslocation(Syslocation obj)
        {
            obj.recid = new int();
            obj.syslocation_createdate = DateTime.Now;
            obj.syslocation_modifydate = DateTime.Now;
            _DbSyslocationContext.SyslocationTable.Add(obj);
            _DbSyslocationContext.SaveChanges();
            return obj;
        }

        public void DeleteSyslocation(int id)
        {

            var items = _DbSyslocationContext.SyslocationTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSyslocationContext.Remove(items.First());
                _DbSyslocationContext.SaveChanges();
            }
        }

        public List<Syslocation> GetSyslocation()
        {
            return _DbSyslocationContext.SyslocationTable.ToList();
        }
        public List<Syslocation> GetSyslocationByCode(string code)
        {
            var items = _DbSyslocationContext.SyslocationTable.Where(item => item.syslocation_name == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Syslocation UpdateSyslocation(Syslocation obj)
        {
            var items = _DbSyslocationContext.SyslocationTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Syslocation = items.FirstOrDefault();

            Syslocation.syslocation_modifydate = DateTime.Now;
            Syslocation.syslocation_name = obj.syslocation_name;
            Syslocation.syslocation_txcomm = obj.syslocation_txcomm;
            Syslocation.syslocation_code = obj.syslocation_code;
            Syslocation.syslocation_status = obj.syslocation_status;

            _DbSyslocationContext.SaveChanges();
            return Syslocation;
        }
    }
}
