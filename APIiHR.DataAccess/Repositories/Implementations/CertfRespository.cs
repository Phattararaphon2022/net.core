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
    public class CertfRespository : ICertfRespository
    {
        private DbCertfContext _DbCertfContext;
        public CertfRespository(DbCertfContext dbCertfContext)
        {
            _DbCertfContext = dbCertfContext;
        }
        public Certf CreateCertf(Certf obj)
        {
            obj.recid = new int();
            obj.certf_createdate = DateTime.Now;
            obj.certf_modifydate = DateTime.Now;
            //obj.recid = 
            //obj.Certf_date = DateTime.Now;
           
            _DbCertfContext.CertfTable.Add(obj);
            _DbCertfContext.SaveChanges();
            return obj;
        }

        public void DeleteCertf(int id)
        {

            var items = _DbCertfContext.CertfTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbCertfContext.Remove(items.First());
                _DbCertfContext.SaveChanges();
            }
        }

        public List<Certf> GetCertf()
        {
            return _DbCertfContext.CertfTable.ToList();
        }
        public List<Certf> GetCertfByCode(string code)
        {
            var items = _DbCertfContext.CertfTable.Where(item => item.certf_worker_code == code)
                .OrderBy(item => item.certf_expdate);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public List<Certf> GetCertfByCodeTop(string code)
        {
            var items = _DbCertfContext.CertfTable.Where(item => item.certf_worker_code == code)
                        .OrderBy(item => item.certf_expdate)
                        .Take(3);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public List<Certf> GetCertfByid(int code)
        {
            var items = _DbCertfContext.CertfTable.Where(item => item.recid == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Certf UpdateCertf(Certf obj)
        {
            var items = _DbCertfContext.CertfTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Certf = items.FirstOrDefault();

            Certf.certf_modifydate = DateTime.Now;
            Certf.certf_worker_code = obj.certf_worker_code;
            Certf.certf_reffile = obj.certf_reffile;
            Certf.certf_expdate = obj.certf_expdate;
            Certf.certf_repdate = obj.certf_repdate;
            Certf.certf_txdesc = obj.certf_txdesc;
            Certf.certf_name = obj.certf_name;

            _DbCertfContext.SaveChanges();
            return Certf;
        }
    }
}
