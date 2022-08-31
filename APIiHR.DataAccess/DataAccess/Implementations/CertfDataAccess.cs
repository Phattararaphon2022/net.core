using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Implementations
{
    public class CertfDataAccess : ICertfDataAccess
    {
        private ICertfRespository _CertfRespository;
        public CertfDataAccess(ICertfRespository CertfRepository)
        {
            _CertfRespository = CertfRepository;
        }
        public Certf CreateCertf(Certf obj)
        {
            return _CertfRespository.CreateCertf(obj);
        }

        public void DeleteCertf(int code)
        {
            _CertfRespository.DeleteCertf(code);
        }

        public List<Certf> GetCertf()
        {
            return _CertfRespository.GetCertf();
        }

        public List<Certf> GetCertfByCode(string code)
        {
            return _CertfRespository.GetCertfByCode(code);

        }
        public List<Certf> GetCertfByCodeTop(string code)
        {
            return _CertfRespository.GetCertfByCodeTop(code);

        }

        public Certf UpdateCertf(Certf obj)
        {
            return _CertfRespository.UpdateCertf(obj);
        }
    }
}
