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
    public class CheckinRespository : ICheckinRespository
    {
        private DbCheckinContext _DbCheckinContext;
        public CheckinRespository(DbCheckinContext dbCheckinContext)
        {
            _DbCheckinContext = dbCheckinContext;
        }
        public Checkin CreateCheckin(Checkin obj)
        {
           
            obj.checkin_createdate = DateTime.Now;
            obj.checkin_modifydate = DateTime.Now;
            obj.checkin_datestartstamp = DateTime.Now;
            obj.checkin_dateend = DateTime.Now;
            obj.checkin_dateendstamp = DateTime.Now;
            _DbCheckinContext.CheckinTable.Add(obj);
            _DbCheckinContext.SaveChanges();
            return obj;
        }

        public void DeleteCheckin(int id)
        {

            var items = _DbCheckinContext.CheckinTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbCheckinContext.Remove(items.First());
                _DbCheckinContext.SaveChanges();
            }
        }

        public List<Checkin> GetCheckin()
        {
            return _DbCheckinContext.CheckinTable.ToList();
        }
        public List<Checkin> GetCheckinByCode(string code)
        {
            var items = _DbCheckinContext.CheckinTable.Where(item => item.checkin_mastercode == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Checkin UpdateCheckin(Checkin obj)
        {
            var items = _DbCheckinContext.CheckinTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Checkin = items.FirstOrDefault();

            Checkin.checkin_modifydate = DateTime.Now;
            Checkin.checkin_datestart = obj.checkin_datestart;
            Checkin.checkin_dateend = obj.checkin_dateend;
            Checkin.checkin_dateendstamp = obj.checkin_dateendstamp;
            Checkin.checkin_worker_code = obj.checkin_worker_code;
            Checkin.checkin_status = obj.checkin_status;
            Checkin.checkin_txdesc = obj.checkin_txdesc;
            Checkin.checkin_mastercode = obj.checkin_mastercode;
            Checkin.checkin_dim1 = obj.checkin_dim1;
            Checkin.checkin_level = obj.checkin_level;

            if (obj.checkin_status == 1)
            {
                Checkin.checkin_dateendstamp = DateTime.Now;
            }

            _DbCheckinContext.SaveChanges();
            return Checkin;
        }
    }
}
