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
    public class CheckinpoiRespository : ICheckinpoiRespository
    {
        private DbCheckinpoiContext _DbCheckinpoiContext;
        public CheckinpoiRespository(DbCheckinpoiContext dbCheckinpoiContext)
        {
            _DbCheckinpoiContext = dbCheckinpoiContext;
        }
        public Checkinpoi CreateCheckinpoi(Checkinpoi obj)
        {
            obj.recid = new int();
            obj.checkinpoi_createdate = DateTime.Now;
            obj.checkinpoi_modifydate = DateTime.Now;
            //obj.recid = 
            //obj.Checkinpoi_date = DateTime.Now;
            _DbCheckinpoiContext.CheckinpoiTable.Add(obj);
            _DbCheckinpoiContext.SaveChanges();
            return obj;
        }

        public void DeleteCheckinpoi(int id)
        {

            var items = _DbCheckinpoiContext.CheckinpoiTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbCheckinpoiContext.Remove(items.First());
                _DbCheckinpoiContext.SaveChanges();
            }
        }

        public List<Checkinpoi> GetCheckinpoi()
        {
            return _DbCheckinpoiContext.CheckinpoiTable.ToList();
        }
        public List<Checkinpoi> GetCheckinpoiByCode(string code)
        {
            var items = _DbCheckinpoiContext.CheckinpoiTable.Where(item => item.checkinpoi_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Checkinpoi UpdateCheckinpoi(Checkinpoi obj)
        {
            var items = _DbCheckinpoiContext.CheckinpoiTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Checkinpoi = items.FirstOrDefault();

            Checkinpoi.checkinpoi_modifydate = DateTime.Now;
            Checkinpoi.checkinpoi_worker_code = obj.checkinpoi_worker_code;
            Checkinpoi.checkinpoi_code = obj.checkinpoi_code;
            Checkinpoi.checkinpoi_lat = obj.checkinpoi_lat;
            Checkinpoi.checkinpoi_lng = obj.checkinpoi_lng;
            Checkinpoi.checkinpoi_typeio = obj.checkinpoi_typeio;

            _DbCheckinpoiContext.SaveChanges();
            return Checkinpoi;
        }
    }
}
