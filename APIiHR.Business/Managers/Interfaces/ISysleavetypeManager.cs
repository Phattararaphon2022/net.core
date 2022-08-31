using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISysleavetypeManager
    {
        List<Sysleavetype> GetSysleavetype();
        List<Sysleavetype> GetSysleavetypeByCode(int code);
        Sysleavetype CreateSysleavetype(Sysleavetype obj);
        Sysleavetype UpdateSysleavetype(int id, Sysleavetype obj);
        void DeleteSysleavetype(int code);
    }
}

