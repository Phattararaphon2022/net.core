using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IApptransManager
    {
        List<Apptrans> GetApptrans();
        List<Apptrans> GetApptransByCode(string code);
        Apptrans CreateApptrans(Apptrans obj);
        Apptrans UpdateApptrans(int id, Apptrans obj);
        void DeleteApptrans(int code);
    }
}
