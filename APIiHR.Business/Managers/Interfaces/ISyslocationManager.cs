using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISyslocationManager 
    {
        List<Syslocation> GetSyslocation();
        List<Syslocation> GetSyslocationByCode(string code);
        Syslocation CreateSyslocation(Syslocation obj);
        Syslocation UpdateSyslocation(int id, Syslocation obj);
        void DeleteSyslocation(int code);
    }
}
