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
    class Sysmttask_lineRespository : ISysmttask_lineRespository
    {
        private DbSysmttask_lineContext _DbSysmttask_lineContext;
        public Sysmttask_lineRespository(DbSysmttask_lineContext dbSysmttask_lineContext)
        {
            _DbSysmttask_lineContext = dbSysmttask_lineContext;
        }
        public Sysmttask_line CreateSysmttask_line(Sysmttask_line obj)
        {
            obj.recid = new int();
            obj.sysmttask_line_createdate = DateTime.Now;
            obj.sysmttask_line_modifydate = DateTime.Now;
            _DbSysmttask_lineContext.Sysmttask_lineTable.Add(obj);
            _DbSysmttask_lineContext.SaveChanges();
            return obj;
        }

        public void DeleteSysmttask_line(int id)
        {

            var items = _DbSysmttask_lineContext.Sysmttask_lineTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysmttask_lineContext.Remove(items.First());
                _DbSysmttask_lineContext.SaveChanges();
            }
        }

        public List<Sysmttask_line> GetSysmttask_line()
        {
            return _DbSysmttask_lineContext.Sysmttask_lineTable.ToList();
        }
        public List<Sysmttask_line> GetSysmttask_lineByCode(string code)
        {
            var items = _DbSysmttask_lineContext.Sysmttask_lineTable.Where(item => item.sysmttask_line_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysmttask_line UpdateSysmttask_line(Sysmttask_line obj)
        {
            var items = _DbSysmttask_lineContext.Sysmttask_lineTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysmttask_line = items.FirstOrDefault();

                Sysmttask_line.sysmttask_line_namealian = obj.sysmttask_line_namealian;
                Sysmttask_line.sysmttask_line_txdesc = obj.sysmttask_line_txdesc;
                Sysmttask_line.sysmttask_line_status = obj.sysmttask_line_status;
                Sysmttask_line.sysmttask_line_code = obj.sysmttask_line_code;
                Sysmttask_line.sysmttask_line_level = obj.sysmttask_line_level;
                Sysmttask_line.sysmttask_line_refidmaster = obj.sysmttask_line_refidmaster;
                Sysmttask_line.sysmttask_line_refcodemaster = obj.sysmttask_line_refcodemaster;
                Sysmttask_line.sysmttask_line_refrecid = obj.sysmttask_line_refrecid;
                Sysmttask_line.sysmttask_line_modifydate = DateTime.Now;
            _DbSysmttask_lineContext.SaveChanges();
            return Sysmttask_line;
        }
    }
}
