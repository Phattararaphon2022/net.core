using APIiHR.Business.Managers.Interfaces;
using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Implementations
{
    public class CertfManager : ICertfManager
    {
        private ICertfDataAccess _CertfDataAccess;
        public CertfManager(ICertfDataAccess CertfDataAccess)
        {
            _CertfDataAccess = CertfDataAccess;
        }

        public Certf CreateCertf(Certf obj)
        {
            return _CertfDataAccess.CreateCertf(obj);
        }

        public void DeleteCertf(int code)
        {
            _CertfDataAccess.DeleteCertf(code);
        }

        public List<Certf> GetCertf()
        {
            return _CertfDataAccess.GetCertf();
        }

        public List<Certf> GetCertfByCode(string code)
        {
            return _CertfDataAccess.GetCertfByCode(code);
        }
        public List<Certf> GetCertfByCodeTop(string code)
        {
            return _CertfDataAccess.GetCertfByCodeTop(code);
        }

        public Certf UpdateCertf(int id, Certf obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _CertfDataAccess.UpdateCertf(obj);
        }
    }
}
