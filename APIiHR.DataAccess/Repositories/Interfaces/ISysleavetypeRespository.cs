using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface ISysleavetypeRespository
    {
        List<Sysleavetype> GetSysleavetype();
        List<Sysleavetype> GetSysleavetypeByCode(int code);

        Sysleavetype CreateSysleavetype(Sysleavetype obj);

        Sysleavetype UpdateSysleavetype(Sysleavetype obj);

        void DeleteSysleavetype(int id);
    }
}
