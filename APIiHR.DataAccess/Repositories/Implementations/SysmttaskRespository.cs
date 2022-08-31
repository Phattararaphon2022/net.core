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
    public class SysmttaskRespository : ISysmttaskRespository
    {
        private DbSysmttaskContext _DbSysmttaskContext;
        public SysmttaskRespository(DbSysmttaskContext dbSysmttaskContext)
        {
            _DbSysmttaskContext = dbSysmttaskContext;
        }
        public Sysmttask CreateSysmttask(Sysmttask obj)
        {
            obj.recid = new int();
            obj.sysmttask_createdate = DateTime.Now;
            _DbSysmttaskContext.SysmttaskTable.Add(obj);
            _DbSysmttaskContext.SaveChanges();
            return obj;
        }

        public void DeleteSysmttask(int id)
        {

            var items = _DbSysmttaskContext.SysmttaskTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysmttaskContext.Remove(items.First());
                _DbSysmttaskContext.SaveChanges();
            }
        }

        public List<Sysmttask> GetSysmttask()
        {
            return _DbSysmttaskContext.SysmttaskTable.ToList();
        }
        public List<Sysmttask> GetSysmttaskByCode(string code)
        {
            var items = _DbSysmttaskContext.SysmttaskTable.Where(item => item.sysmttask_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysmttask UpdateSysmttask(Sysmttask obj)
        {
            var items = _DbSysmttaskContext.SysmttaskTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysmttask = items.FirstOrDefault();

            Sysmttask.sysmttask_namealian = obj.sysmttask_namealian;
            Sysmttask.sysmttask_txdesc = obj.sysmttask_txdesc;
            Sysmttask.sysmttask_status = obj.sysmttask_status;
            Sysmttask.sysmttask_code = obj.sysmttask_code;
            Sysmttask.sysmttask_level = obj.sysmttask_level;
            Sysmttask.sysmttask_refdim1 = obj.sysmttask_refdim1;
            Sysmttask.sysmttask_refdim2 = obj.sysmttask_refdim2;

            _DbSysmttaskContext.SaveChanges();
            return Sysmttask;
        }
    }
}
