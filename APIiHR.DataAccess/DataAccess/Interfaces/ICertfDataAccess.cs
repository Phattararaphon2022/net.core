using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ICertfDataAccess
    {
        List<Certf> GetCertf();
        List<Certf> GetCertfByCode(string code);
        List<Certf> GetCertfByCodeTop(string code);
        Certf CreateCertf(Certf obj);
        Certf UpdateCertf(Certf obj);
        void DeleteCertf(int code);
    }
}
