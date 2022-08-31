using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ISysfileessDataAccess
    {
        List<Sysfileess> GetSysfileess();
        List<Sysfileess> GetSysfileessByCode(int code);
        Sysfileess CreateSysfileess(Sysfileess obj);
        Sysfileess UpdateSysfileess(Sysfileess obj);
        void DeleteSysfileess(int code);
    }
}
