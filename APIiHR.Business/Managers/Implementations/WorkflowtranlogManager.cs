using APIiHR.Business.Managers.Interfaces;
using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Implementations
{
    public class WorkflowtranlogManager : IWorkflowtranlogManager
    {
        private IWorkflowtranlogDataAccess _WorkflowtranlogDataAccess;
        public WorkflowtranlogManager(IWorkflowtranlogDataAccess WorkflowtranlogDataAccess)
        {
            _WorkflowtranlogDataAccess = WorkflowtranlogDataAccess;
        }

        public Workflowtranlog CreateWorkflowtranlog(Workflowtranlog obj)
        {
            return _WorkflowtranlogDataAccess.CreateWorkflowtranlog(obj);
        }

        public void DeleteWorkflowtranlog(int code)
        {
            _WorkflowtranlogDataAccess.DeleteWorkflowtranlog(code);
        }

        public List<Workflowtranlog> GetWorkflowtranlog()
        {
            return _WorkflowtranlogDataAccess.GetWorkflowtranlog();
        }

        public List<Workflowtranlog> GetWorkflowtranlogByCode(string code)
        {
            return _WorkflowtranlogDataAccess.GetWorkflowtranlogByCode(code);
        }

        public Workflowtranlog UpdateWorkflowtranlog(int id, Workflowtranlog obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _WorkflowtranlogDataAccess.UpdateWorkflowtranlog(obj);
        }
    }
}
