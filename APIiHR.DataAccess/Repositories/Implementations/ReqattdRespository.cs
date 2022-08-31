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
    public class ReqattdRespository : IReqattdRespository
    {
        private DbReqattdContext _DbReqattdContext;
        public ReqattdRespository(DbReqattdContext dbReqattdContext)
        {
            _DbReqattdContext = dbReqattdContext;
        }
        public Reqattd CreateReqattd(Reqattd obj)
        {          
            obj.reqattd_ihr_ref1 = this.getDocumentNumberSeq();
            obj.reqattd_ihr_ref2 = Guid.NewGuid().ToString();

            obj.recid = new int();
            obj.reqattd_createdate = DateTime.Now;
            obj.reqattd_caltime = 2;
            obj.reqattd_datecheckin = DateTime.Now;
            obj.reqattd_timein = DateTime.Now;
            obj.reqattd_timeout = DateTime.Now;
            //obj.recid = 
            //obj.Reqattd_date = DateTime.Now;

            _DbReqattdContext.ReqattdTable.Add(obj);
            _DbReqattdContext.SaveChanges();
            return obj;
        }
        public string getDocumentNumberSeq()
        {
            string docno_countfm = "EAT" + long.Parse(DateTime.Now.ToString("yyMMdd"));

            int docno_count = 0;
            int count_z = 0;

            var items = _DbReqattdContext.ReqattdTable.ToList();
            if (items.Any())
            {
                docno_count = (items.Count + 1) % 1000;
                for (int i = 1; i < (4 - docno_count.ToString().Length); i++)
                {
                    docno_countfm = docno_countfm + "0";
                }
                docno_countfm = docno_countfm + docno_count.ToString();
            }
            return docno_countfm;
        }

        public void DeleteReqattd(int id)
        {

            var items = _DbReqattdContext.ReqattdTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbReqattdContext.Remove(items.First());
                _DbReqattdContext.SaveChanges();
            }
        }

        public List<Reqattd> GetReqattd()
        {
            return _DbReqattdContext.ReqattdTable.ToList();
        }
        public List<Reqattd> GetReqattdByCode(string code)
        {
            var items = _DbReqattdContext.ReqattdTable.Where(item => item.reqattd_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Reqattd UpdateReqattd(Reqattd obj)
        {
            var items = _DbReqattdContext.ReqattdTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Reqattd = items.FirstOrDefault();

           // Reqattd.Reqattd_cutoff = obj.Reqattd_cutoff;
            //Reqattd.Reqattd_date = obj.Reqattd_date;
            Reqattd.reqattd_createdate = DateTime.Now;

            Reqattd.reqattd_datecheckin = obj.reqattd_datecheckin;
            Reqattd.reqattd_txdesc = obj.reqattd_txdesc;
            Reqattd.reqattd_type = obj.reqattd_type;
            Reqattd.reqattd_worker_code = obj.reqattd_worker_code;
            Reqattd.reqattd_pathdoc = obj.reqattd_pathdoc;
            Reqattd.reqattd_refcodetran = obj.reqattd_refcodetran;

            Reqattd.reqattd_refdesc = obj.reqattd_refdesc;
            Reqattd.reqattd_caltime = obj.reqattd_caltime;
            Reqattd.reqattd_ihr_ref1 = obj.reqattd_ihr_ref1;
            Reqattd.reqattd_ihr_ref2 = obj.reqattd_ihr_ref2;

            _DbReqattdContext.SaveChanges();
            return Reqattd;
        }
    }
}
