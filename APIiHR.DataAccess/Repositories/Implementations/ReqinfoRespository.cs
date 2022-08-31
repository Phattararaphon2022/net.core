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
    public class ReqinfoRespository : IReqinfoRespository
    {
        private DbReqinfoContext _DbReqinfoContext;
        public ReqinfoRespository(DbReqinfoContext dbReqinfoContext)
        {
            _DbReqinfoContext = dbReqinfoContext;
        }
        public Reqinfo CreateReqinfo(Reqinfo obj)
        {
            // obj.recid = new int();
            long n = long.Parse(DateTime.Now.ToString("yyMMddHHmmss"));
            obj.reqinfo_ihr_ref1 = "ES" + n.ToString();
            obj.reqinfo_ihr_ref2 = Guid.NewGuid().ToString();
            obj.reqinfo_createdate = DateTime.Now;
            //obj.recid = 
            //obj.Reqinfo_date = DateTime.Now;            
            _DbReqinfoContext.ReqinfoTable.Add(obj);
            _DbReqinfoContext.SaveChanges();
           
            return obj;
        }

        public void DeleteReqinfo(int id)
        {

            var items = _DbReqinfoContext.ReqinfoTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbReqinfoContext.Remove(items.First());
                _DbReqinfoContext.SaveChanges();
            }
        }

        public List<Reqinfo> GetReqinfo()
        {
            return _DbReqinfoContext.ReqinfoTable.ToList();
        }
        public List<Reqinfo> GetReqinfoByCode(int code)
        {
            var items = _DbReqinfoContext.ReqinfoTable.Where(item => item.recid == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Reqinfo UpdateReqinfo(Reqinfo obj)
        {
            var items = _DbReqinfoContext.ReqinfoTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Reqinfo = items.FirstOrDefault();

           // Reqinfo.Reqinfo_cutoff = obj.Reqinfo_cutoff;
            //Reqinfo.Reqinfo_date = obj.Reqinfo_date;
            Reqinfo.reqinfo_createdate = DateTime.Now;

            Reqinfo.reqinfo_createdate = obj.reqinfo_createdate;
            Reqinfo.reqinfo_infotext = obj.reqinfo_infotext;
            Reqinfo.reqinfo_txdesc = obj.reqinfo_txdesc;
            Reqinfo.reqinfo_worker_code = obj.reqinfo_worker_code;
            Reqinfo.reqinfo_status = obj.reqinfo_status;
            Reqinfo.reqinfo_ihr_ref1 = obj.reqinfo_ihr_ref1;
            Reqinfo.reqinfo_ihr_ref2 = obj.reqinfo_ihr_ref2;


            _DbReqinfoContext.SaveChanges();
            return Reqinfo;
        }
    }
}
