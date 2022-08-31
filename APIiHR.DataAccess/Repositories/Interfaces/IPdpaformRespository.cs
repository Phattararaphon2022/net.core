using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface IPdpaformRespository
    {
        List<Pdpaform> GetPdpaform();
        List<Pdpaform> GetPdpaformByCode(string code);

        Pdpaform CreatePdpaform(Pdpaform obj);

        Pdpaform UpdatePdpaform(Pdpaform obj);

        void DeletePdpaform(int id);
    }
}
