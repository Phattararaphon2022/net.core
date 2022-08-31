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
    public class SysmodulenoRespository : ISysmodulenoRespository
    {
        private DbSysmodulenoContext _DbSysmodulenoContext;
        public SysmodulenoRespository(DbSysmodulenoContext dbSysmodulenoContext)
        {
            _DbSysmodulenoContext = dbSysmodulenoContext;
        }
        public Sysmoduleno CreateSysmoduleno(Sysmoduleno obj)
        {
            obj.recid = new int();
            obj.sysmoduleno_createdate = DateTime.Now;
            obj.sysmoduleno_modifydate = DateTime.Now;
            _DbSysmodulenoContext.SysmodulenoTable.Add(obj);
            _DbSysmodulenoContext.SaveChanges();
            return obj;
        }

        public void DeleteSysmoduleno(int id)
        {

            var items = _DbSysmodulenoContext.SysmodulenoTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysmodulenoContext.Remove(items.First());
                _DbSysmodulenoContext.SaveChanges();
            }
        }

        public List<Sysmoduleno> GetSysmoduleno()
        {
            return _DbSysmodulenoContext.SysmodulenoTable.ToList();
        }
        public List<Sysmoduleno> GetSysmodulenoByCode(string code)
        {
            var items = _DbSysmodulenoContext.SysmodulenoTable.Where(item => item.sysmoduleno_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysmoduleno UpdateSysmoduleno(Sysmoduleno obj)
        {
            var items = _DbSysmodulenoContext.SysmodulenoTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysmoduleno = items.FirstOrDefault();
                Sysmoduleno.sysmoduleno_modifydate = DateTime.Now;
                Sysmoduleno.sysmoduleno_code = obj.sysmoduleno_code;
                Sysmoduleno.sysmoduleno_name = obj.sysmoduleno_name;
                Sysmoduleno.sysmoduleno_refname = obj.sysmoduleno_refname;
                Sysmoduleno.sysmoduleno_txdesc = obj.sysmoduleno_txdesc;
                Sysmoduleno.sysmoduleno_status = obj.sysmoduleno_status;
                Sysmoduleno.sysmoduleno_codeold = obj.sysmoduleno_codeold;

            _DbSysmodulenoContext.SaveChanges();
            return Sysmoduleno;
        }
    }
}
