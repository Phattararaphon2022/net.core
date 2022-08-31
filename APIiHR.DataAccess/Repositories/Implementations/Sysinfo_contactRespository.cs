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
    public class Sysinfo_contactRespository : ISysinfo_contactRespository
    {
        private DbSysinfo_contactContext _DbSysinfo_contactContext;
        public Sysinfo_contactRespository(DbSysinfo_contactContext dbSysinfo_contactContext)
        {
            _DbSysinfo_contactContext = dbSysinfo_contactContext;
        }
        public Sysinfo_contact CreateSysinfo_contact(Sysinfo_contact obj)
        {
            obj.recid = new int();
            obj.sysinfo_contact_createdate = DateTime.Now;
            obj.sysinfo_contact_modifydate = DateTime.Now;
            _DbSysinfo_contactContext.Sysinfo_contactTable.Add(obj);
            _DbSysinfo_contactContext.SaveChanges();
            return obj;
        }

        public void DeleteSysinfo_contact(int id)
        {

            var items = _DbSysinfo_contactContext.Sysinfo_contactTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysinfo_contactContext.Remove(items.First());
                _DbSysinfo_contactContext.SaveChanges();
            }
        }

        public List<Sysinfo_contact> GetSysinfo_contact()
        {
            return _DbSysinfo_contactContext.Sysinfo_contactTable.ToList();
        }
        public List<Sysinfo_contact> GetSysinfo_contactByCode(string code)
        {
            var items = _DbSysinfo_contactContext.Sysinfo_contactTable.Where(item => item.sysinfo_contact_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysinfo_contact UpdateSysinfo_contact(Sysinfo_contact obj)
        {
            var items = _DbSysinfo_contactContext.Sysinfo_contactTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysinfo_contact = items.FirstOrDefault();

            Sysinfo_contact.sysinfo_contact_modifydate = DateTime.Now;
            Sysinfo_contact.sysinfo_contact_worker_code = obj.sysinfo_contact_worker_code;
            Sysinfo_contact.sysinfo_contact_name = obj.sysinfo_contact_name;
            Sysinfo_contact.sysinfo_contact_mobile = obj.sysinfo_contact_mobile;
            Sysinfo_contact.sysinfo_contact_tel = obj.sysinfo_contact_tel;
            Sysinfo_contact.sysinfo_contact_address = obj.sysinfo_contact_address;
            Sysinfo_contact.sysinfo_contact_status = obj.sysinfo_contact_status;

            Sysinfo_contact.sysinfo_contact_reftran = obj.sysinfo_contact_reftran;
            Sysinfo_contact.sysinfo_contact_refdim1 = obj.sysinfo_contact_refdim1;
            Sysinfo_contact.sysinfo_contact_refdimrec = obj.sysinfo_contact_refdimrec;


            _DbSysinfo_contactContext.SaveChanges();
            return Sysinfo_contact;
        }
    }
}
