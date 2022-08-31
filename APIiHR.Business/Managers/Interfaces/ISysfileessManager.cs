using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISysfileessManager
    {
        List<Sysfileess> GetSysfileess();
        List<Sysfileess> GetSysfileessByCode(int code);
        Sysfileess CreateSysfileess(Sysfileess obj);
        Sysfileess UpdateSysfileess(int id, Sysfileess obj);
        void DeleteSysfileess(int code);
    }
}
