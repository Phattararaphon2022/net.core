using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface IApptransDataAccess
    {
        List<Apptrans> GetApptrans();
        List<Apptrans> GetApptransByCode(string code);
        Apptrans CreateApptrans(Apptrans obj);
        Apptrans UpdateApptrans(Apptrans obj);
        void DeleteApptrans(int code);
    }
}
