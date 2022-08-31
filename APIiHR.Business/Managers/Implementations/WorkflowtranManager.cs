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
    public class WorkflowtranManager : IWorkflowtranManager
    {
        private IWorkflowtranDataAccess _WorkflowtranDataAccess;
        public WorkflowtranManager(IWorkflowtranDataAccess WorkflowtranDataAccess)
        {
            _WorkflowtranDataAccess = WorkflowtranDataAccess;
        }

        public Workflowtran CreateWorkflowtran(Workflowtran obj)
        {
            return _WorkflowtranDataAccess.CreateWorkflowtran(obj);
        }

        public void DeleteWorkflowtran(int code)
        {
            _WorkflowtranDataAccess.DeleteWorkflowtran(code);
        }

        public List<Workflowtran> GetWorkflowtran()
        {
            return _WorkflowtranDataAccess.GetWorkflowtran();
        }

        public List<Workflowtran> GetWorkflowtranByCode(int code)
        {
            return _WorkflowtranDataAccess.GetWorkflowtranByCode(code);
        }

        public Workflowtran UpdateWorkflowtran(int id, Workflowtran obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _WorkflowtranDataAccess.UpdateWorkflowtran(obj);
        }
    }
}
