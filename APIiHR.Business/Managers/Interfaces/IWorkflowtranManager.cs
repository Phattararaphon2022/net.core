using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IWorkflowtranManager
    {
        List<Workflowtran> GetWorkflowtran();
        List<Workflowtran> GetWorkflowtranByCode(int code);
        Workflowtran CreateWorkflowtran(Workflowtran obj);
        Workflowtran UpdateWorkflowtran(int id, Workflowtran obj);
        void DeleteWorkflowtran(int code);
    }
}
