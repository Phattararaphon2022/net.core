using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IPdpaformManager
    {
        List<Pdpaform> GetPdpaform();
        List<Pdpaform> GetPdpaformByCode(string code);
        Pdpaform CreatePdpaform(Pdpaform obj);
        Pdpaform UpdatePdpaform(int id, Pdpaform obj);
        void DeletePdpaform(int code);
    }
}
