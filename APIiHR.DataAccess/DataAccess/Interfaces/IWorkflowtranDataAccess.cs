using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface IWorkflowtranDataAccess
    {
        List<Workflowtran> GetWorkflowtran();
        List<Workflowtran> GetWorkflowtranByCode(int code);
        Workflowtran CreateWorkflowtran(Workflowtran obj);
        Workflowtran UpdateWorkflowtran(Workflowtran obj);
        void DeleteWorkflowtran(int code);
    }
}
