using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IWorkflowtranlogManager
    {
        List<Workflowtranlog> GetWorkflowtranlog();
        List<Workflowtranlog> GetWorkflowtranlogByCode(string code);
        Workflowtranlog CreateWorkflowtranlog(Workflowtranlog obj);
        Workflowtranlog UpdateWorkflowtranlog(int id, Workflowtranlog obj);
        void DeleteWorkflowtranlog(int code);
    }
}
