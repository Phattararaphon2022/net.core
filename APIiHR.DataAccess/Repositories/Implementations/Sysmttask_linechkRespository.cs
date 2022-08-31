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
    public class Sysmttask_linechkRespository : ISysmttask_linechkRespository
    {
        private DbSysmttask_linechkContext _DbSysmttask_linechkContext;
        public Sysmttask_linechkRespository(DbSysmttask_linechkContext dbSysmttask_linechkContext)
        {
            _DbSysmttask_linechkContext = dbSysmttask_linechkContext;
        }
        public Sysmttask_linechk CreateSysmttask_linechk(Sysmttask_linechk obj)
        {
            obj.recid = new int();
            obj.sysmttask_linechk_createdate = DateTime.Now;
            obj.sysmttask_linechk_modifydate = DateTime.Now;
            _DbSysmttask_linechkContext.Sysmttask_linechkTable.Add(obj);
            _DbSysmttask_linechkContext.SaveChanges();
            return obj;
        }

        public void DeleteSysmttask_linechk(int id)
        {

            var items = _DbSysmttask_linechkContext.Sysmttask_linechkTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysmttask_linechkContext.Remove(items.First());
                _DbSysmttask_linechkContext.SaveChanges();
            }
        }

        public List<Sysmttask_linechk> GetSysmttask_linechk()
        {
            return _DbSysmttask_linechkContext.Sysmttask_linechkTable.ToList();
        }
        public List<Sysmttask_linechk> GetSysmttask_linechkByCode(string code)
        {
            var items = _DbSysmttask_linechkContext.Sysmttask_linechkTable.Where(item => item.sysmttask_linechk_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysmttask_linechk UpdateSysmttask_linechk(Sysmttask_linechk obj)
        {
            var items = _DbSysmttask_linechkContext.Sysmttask_linechkTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysmttask_linechk = items.FirstOrDefault();

            Sysmttask_linechk.sysmttask_linechk_namealian = obj.sysmttask_linechk_namealian;
            Sysmttask_linechk.sysmttask_linechk_txdesc = obj.sysmttask_linechk_txdesc;
            Sysmttask_linechk.sysmttask_linechk_status = obj.sysmttask_linechk_status;
            Sysmttask_linechk.sysmttask_linechk_code = obj.sysmttask_linechk_code;
            Sysmttask_linechk.sysmttask_linechk_level = obj.sysmttask_linechk_level;
            Sysmttask_linechk.sysmttask_linechk_refidmaster = obj.sysmttask_linechk_refidmaster;
            Sysmttask_linechk.sysmttask_linechk_refcodemaster = obj.sysmttask_linechk_refcodemaster;
            Sysmttask_linechk.sysmttask_linechk_refrecid = obj.sysmttask_linechk_refrecid;
            Sysmttask_linechk.sysmttask_linechk_modifydate = DateTime.Now;
            Sysmttask_linechk.sysmttask_linechk_worker_code = obj.sysmttask_linechk_worker_code;
            _DbSysmttask_linechkContext.SaveChanges();
            return Sysmttask_linechk;
        }
    }
}
