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
    public class ReqotRespository : IReqotRespository
    {
        private DbReqotContext _DbReqotContext;
        public ReqotRespository(DbReqotContext dbReqotContext)
        {
            _DbReqotContext = dbReqotContext;
        }
        public Reqot CreateReqot(Reqot obj)
        {            
            obj.reqot_ihr_ref1 = this.getDocumentNumberSeq();
            obj.reqot_ihr_ref2 = Guid.NewGuid().ToString();


            obj.recid = new int();

            obj.reqot_createdate = DateTime.Now;
            //obj.recid = 
            //obj.reqot_date = DateTime.Now;
            obj.reqot_timetotal = obj.reqot_timeafter + obj.reqot_timebefore + obj.reqot_timenormal;
            _DbReqotContext.ReqotTable.Add(obj);
            _DbReqotContext.SaveChanges();
            return obj;
        }
        public string getDocumentNumberSeq()
        {
            string docno_countfm = "EOT" + long.Parse(DateTime.Now.ToString("yyMMdd"));

            int docno_count = 0;
            int count_z = 0;

            var items = _DbReqotContext.ReqotTable.ToList();
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

        public void DeleteReqot(int id)
        {

            var items = _DbReqotContext.ReqotTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbReqotContext.Remove(items.First());
                _DbReqotContext.SaveChanges();
            }
        }

        public List<Reqot> GetReqot()
        {
            return _DbReqotContext.ReqotTable.ToList();
        }
        public List<Reqot> GetReqotByCode(string code)
        {
            var items = _DbReqotContext.ReqotTable.Where(item => item.reqot_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Reqot UpdateReqot(Reqot obj)
        {
            var items = _DbReqotContext.ReqotTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Reqot = items.FirstOrDefault();

            Reqot.reqot_cutoff = obj.reqot_cutoff;
            //Reqot.reqot_date = obj.reqot_date;
            Reqot.reqot_date = DateTime.Now;
            Reqot.reqot_desc = obj.reqot_desc;
            Reqot.reqot_timeafter = obj.reqot_timeafter;
            Reqot.reqot_timebefore = obj.reqot_timebefore;
            Reqot.reqot_timenormal = obj.reqot_timenormal;
            Reqot.reqot_worker_code = obj.reqot_worker_code;
            Reqot.reqot_timetotal = obj.reqot_timeafter + obj.reqot_timebefore + obj.reqot_timenormal;
            Reqot.reqot_refcodetran = obj.reqot_refcodetran;
            Reqot.reqot_ihr_ref1 = obj.reqot_ihr_ref1;
            Reqot.reqot_ihr_ref2 = obj.reqot_ihr_ref2;

            _DbReqotContext.SaveChanges();
            return Reqot;
        }
    }
}
