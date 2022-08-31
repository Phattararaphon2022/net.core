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
    public class ReqleaveRespository : IReqleaveRespository
    {
        private DbReqleaveContext _DbReqleaveContext;
        public ReqleaveRespository(DbReqleaveContext dbReqleaveContext)
        {
            _DbReqleaveContext = dbReqleaveContext;
        }
        public Reqleave CreateReqleave(Reqleave obj)
        {            
            obj.reqleave_ihr_ref1 = this.getDocumentNumberSeq();
            obj.reqleave_ihr_ref2 = Guid.NewGuid().ToString();

            obj.recid = new int();
            obj.reqleave_createdate = DateTime.Now;
            //obj.recid = 
            //obj.Reqleave_date = DateTime.Now;
           // obj.Reqleave_timetotal = obj.Reqleave_timeafter + obj.Reqleave_timebefore + obj.Reqleave_timenormal;
            _DbReqleaveContext.ReqleaveTable.Add(obj);
            _DbReqleaveContext.SaveChanges();
            return obj;
        }

        public void DeleteReqleave(int id)
        {

            var items = _DbReqleaveContext.ReqleaveTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbReqleaveContext.Remove(items.First());
                _DbReqleaveContext.SaveChanges();
            }
        }

        public List<Reqleave> GetReqleave()
        {
            return _DbReqleaveContext.ReqleaveTable.ToList();
        }
        public string getDocumentNumberSeq()
        {
            string docno_countfm = "ELV" + long.Parse(DateTime.Now.ToString("yyMMdd")); 
            
            int docno_count = 0;
            int count_z = 0;

            var items = _DbReqleaveContext.ReqleaveTable.ToList();
            if(items.Any())
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
        public List<Reqleave> GetReqleaveByCode(string code)
        {
            var items = _DbReqleaveContext.ReqleaveTable.Where(item => item.reqleave_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Reqleave UpdateReqleave(Reqleave obj)
        {
            var items = _DbReqleaveContext.ReqleaveTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Reqleave = items.FirstOrDefault();
            
            Reqleave.reqleave_dateleave = obj.reqleave_dateleave;
            Reqleave.reqleave_fulldate = obj.reqleave_fulldate;
            Reqleave.reqleave_txdesc = obj.reqleave_txdesc;
            Reqleave.reqleave_infodesc = obj.reqleave_infodesc;
            Reqleave.reqleave_worker_code = obj.reqleave_worker_code;
            Reqleave.reqleave_status = obj.reqleave_status;
            Reqleave.reqleave_cutoff = obj.reqleave_cutoff;
            Reqleave.reqleave_filepath = obj.reqleave_filepath;

            Reqleave.reqleave_reftype = obj.reqleave_reftype;
            Reqleave.reqleave_datetype = obj.reqleave_datetype;
            Reqleave.reqleave_dateqty = obj.reqleave_dateqty;

            Reqleave.reqleave_ihr_ref1 = obj.reqleave_ihr_ref1;
            Reqleave.reqleave_ihr_ref2 = obj.reqleave_ihr_ref2;


            _DbReqleaveContext.SaveChanges();
            return Reqleave;
        }
    }
}
