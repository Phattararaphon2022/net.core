using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ICertfManager
    {
        List<Certf> GetCertf();
        List<Certf> GetCertfByCode(string code);
        List<Certf> GetCertfByCodeTop(string code);
        Certf CreateCertf(Certf obj);
        Certf UpdateCertf(int id, Certf obj);
        void DeleteCertf(int code);
    }
}
