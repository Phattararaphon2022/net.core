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
    public class SyslogininfoRespository : ISyslogininfoRespository
    {
        private DbSyslogininfoContext _DbSyslogininfoContext;
        public SyslogininfoRespository(DbSyslogininfoContext dbSyslogininfoContext)
        {
            _DbSyslogininfoContext = dbSyslogininfoContext;
        }
        public Syslogininfo CreateSyslogininfo(Syslogininfo obj)
        {
            obj.recid = new int();
            obj.syslogininfo_createdate = DateTime.Now;
            obj.syslogininfo_modifydate = DateTime.Now;
            _DbSyslogininfoContext.SyslogininfoTable.Add(obj);
            _DbSyslogininfoContext.SaveChanges();
            return obj;
        }

        public void DeleteSyslogininfo(int id)
        {

            var items = _DbSyslogininfoContext.SyslogininfoTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSyslogininfoContext.Remove(items.First());
                _DbSyslogininfoContext.SaveChanges();
            }
        }

        public List<Syslogininfo> GetSyslogininfo()
        {
            return _DbSyslogininfoContext.SyslogininfoTable.ToList();
        }
        public List<Syslogininfo> GetSyslogininfoByCode(string code)
        {
            var items = _DbSyslogininfoContext.SyslogininfoTable.Where(item => item.syslogininfo_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Syslogininfo UpdateSyslogininfo(Syslogininfo obj)
        {
            var items = _DbSyslogininfoContext.SyslogininfoTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Syslogininfo = items.FirstOrDefault();

            Syslogininfo.syslogininfo_modifydate = DateTime.Now;
            Syslogininfo.syslogininfo_type = obj.syslogininfo_type;
            Syslogininfo.syslogininfo_txt = obj.syslogininfo_txt;
            Syslogininfo.syslogininfo_worker_code = obj.syslogininfo_worker_code;
            Syslogininfo.syslogininfo_startdate = obj.syslogininfo_startdate;
            Syslogininfo.syslogininfo_enddate = obj.syslogininfo_enddate;
            Syslogininfo.syslogininfo_status = obj.syslogininfo_status;

            _DbSyslogininfoContext.SaveChanges();
            return Syslogininfo;
        }
    }
}
