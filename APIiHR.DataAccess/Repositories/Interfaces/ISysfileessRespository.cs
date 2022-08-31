using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface ISysfileessRespository
    {
        List<Sysfileess> GetSysfileess();
        List<Sysfileess> GetSysfileessByCode(int code);

        Sysfileess CreateSysfileess(Sysfileess obj);

        Sysfileess UpdateSysfileess(Sysfileess obj);

        void DeleteSysfileess(int id);
    }
}

