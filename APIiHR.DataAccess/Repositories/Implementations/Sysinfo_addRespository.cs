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
    public class Sysinfo_addRespository : ISysinfo_addRespository
    {
        private DbSysinfo_addContext _DbSysinfo_addContext;
        public Sysinfo_addRespository(DbSysinfo_addContext dbSysinfo_addContext)
        {
            _DbSysinfo_addContext = dbSysinfo_addContext;
        }
        public Sysinfo_add CreateSysinfo_add(Sysinfo_add obj)
        {
            obj.recid = new int();
            obj.sysinfo_add_createdate = DateTime.Now;
            //obj.recid = 
            //obj.Sysinfo_add_date = DateTime.Now;
            
            _DbSysinfo_addContext.Sysinfo_addTable.Add(obj);
            _DbSysinfo_addContext.SaveChanges();
            return obj;
        }

        public void DeleteSysinfo_add(int id)
        {

            var items = _DbSysinfo_addContext.Sysinfo_addTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysinfo_addContext.Remove(items.First());
                _DbSysinfo_addContext.SaveChanges();
            }
        }

        public List<Sysinfo_add> GetSysinfo_add()
        {
            return _DbSysinfo_addContext.Sysinfo_addTable.ToList();
        }
        public List<Sysinfo_add> GetSysinfo_addByCode(string code)
        {
            var items = _DbSysinfo_addContext.Sysinfo_addTable.Where(item => item.sysinfo_add_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysinfo_add UpdateSysinfo_add(Sysinfo_add obj)
        {
            var items = _DbSysinfo_addContext.Sysinfo_addTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysinfo_add = items.FirstOrDefault();

           
            Sysinfo_add.sysinfo_add_createdate = DateTime.Now;
            Sysinfo_add.sysinfo_add_namealian = obj.sysinfo_add_namealian;

            Sysinfo_add.sysinfo_add_moo = obj.sysinfo_add_moo;
            Sysinfo_add.sysinfo_add_soi = obj.sysinfo_add_soi;
            Sysinfo_add.sysinfo_add_road = obj.sysinfo_add_road;
            Sysinfo_add.sysinfo_add_tambon = obj.sysinfo_add_tambon;
            Sysinfo_add.sysinfo_add_amphur = obj.sysinfo_add_amphur;
            Sysinfo_add.sysinfo_add_province = obj.sysinfo_add_province;
            Sysinfo_add.sysinfo_add_addressno = obj.sysinfo_add_addressno;
            Sysinfo_add.sysinfo_add_zipcode = obj.sysinfo_add_zipcode;
            Sysinfo_add.sysinfo_add_status = obj.sysinfo_add_status;

            Sysinfo_add.sysinfo_add_reftran = obj.sysinfo_add_reftran;
            Sysinfo_add.sysinfo_add_refdim1 = obj.sysinfo_add_refdim1;
            Sysinfo_add.sysinfo_add_refdimrec = obj.sysinfo_add_refdimrec;



            _DbSysinfo_addContext.SaveChanges();
            return Sysinfo_add;
        }
    }
}
