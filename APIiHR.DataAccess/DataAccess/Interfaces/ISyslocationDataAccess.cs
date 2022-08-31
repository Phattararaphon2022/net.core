using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ISyslocationDataAccess
    {
        List<Syslocation> GetSyslocation();
        List<Syslocation> GetSyslocationByCode(string code);
        Syslocation CreateSyslocation(Syslocation obj);
        Syslocation UpdateSyslocation(Syslocation obj);
        void DeleteSyslocation(int code);
    }
}
