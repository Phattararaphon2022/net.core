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
    public class ReqchgshiftRespository : IReqchgshiftRespository
    {
        private DbReqchgshiftContext _DbReqchgshiftContext;
        public ReqchgshiftRespository(DbReqchgshiftContext dbReqchgshiftContext)
        {
            _DbReqchgshiftContext = dbReqchgshiftContext;
        }
        public Reqchgshift CreateReqchgshift(Reqchgshift obj)
        {            
            obj.reqchgshift_ihr_ref1 = this.getDocumentNumberSeq(); 
            obj.reqchgshift_ihr_ref2 = Guid.NewGuid().ToString();

            obj.recid = new int();            
            obj.reqchgshift_createdate = DateTime.Now;
            //obj.recid = 
            //obj.Reqchgshift_date = DateTime.Now;
           
            _DbReqchgshiftContext.ReqchgshiftTable.Add(obj);
            _DbReqchgshiftContext.SaveChanges();
            return obj;
        }
        public string getDocumentNumberSeq()
        {
            string docno_countfm = "ESH" + long.Parse(DateTime.Now.ToString("yyMMdd"));

            int docno_count = 0;
            int count_z = 0;

            var items = _DbReqchgshiftContext.ReqchgshiftTable.ToList();
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

        public void DeleteReqchgshift(int id)
        {

            var items = _DbReqchgshiftContext.ReqchgshiftTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbReqchgshiftContext.Remove(items.First());
                _DbReqchgshiftContext.SaveChanges();
            }
        }

        public List<Reqchgshift> GetReqchgshift()
        {          
            return _DbReqchgshiftContext.ReqchgshiftTable.ToList();
        }
        public List<Reqchgshift> GetReqchgshiftByCode(string code)
        {
            var items = _DbReqchgshiftContext.ReqchgshiftTable.Where(item => item.reqchgshift_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Reqchgshift UpdateReqchgshift(Reqchgshift obj)
        {
            var items = _DbReqchgshiftContext.ReqchgshiftTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Reqchgshift = items.FirstOrDefault();

            Reqchgshift.reqchgshift_datechgnew = obj.reqchgshift_datechgnew;
            Reqchgshift.reqchgshift_datechgold = obj.reqchgshift_datechgold;
            Reqchgshift.reqchgshift_txdesc = obj.reqchgshift_txdesc;
            Reqchgshift.reqchgshift_status = obj.reqchgshift_status;
            Reqchgshift.reqchgshift_worker_code = obj.reqchgshift_worker_code;
            Reqchgshift.reqchgshift_pathdoc = obj.reqchgshift_pathdoc;
            Reqchgshift.reqchgshift_type = obj.reqchgshift_type;
            Reqchgshift.reqchgshift_ihr_ref1 = obj.reqchgshift_ihr_ref1;
            Reqchgshift.reqchgshift_ihr_ref2 = obj.reqchgshift_ihr_ref2;

            _DbReqchgshiftContext.SaveChanges();
            return Reqchgshift;
        }
    }
}
