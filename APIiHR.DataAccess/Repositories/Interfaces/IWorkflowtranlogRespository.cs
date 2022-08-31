using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface IWorkflowtranlogRespository
    {
        List<Workflowtranlog> GetWorkflowtranlog();
        List<Workflowtranlog> GetWorkflowtranlogByCode(string code);

        Workflowtranlog CreateWorkflowtranlog(Workflowtranlog obj);

        Workflowtranlog UpdateWorkflowtranlog(Workflowtranlog obj);

        void DeleteWorkflowtranlog(int id);
    }
}
