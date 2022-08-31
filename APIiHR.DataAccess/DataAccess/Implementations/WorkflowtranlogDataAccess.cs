using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Implementations
{
    public class WorkflowtranlogDataAccess : IWorkflowtranlogDataAccess
    {
        private IWorkflowtranlogRespository _WorkflowtranlogRespository;
        public WorkflowtranlogDataAccess(IWorkflowtranlogRespository WorkflowtranlogRepository)
        {
            _WorkflowtranlogRespository = WorkflowtranlogRepository;
        }
        public Workflowtranlog CreateWorkflowtranlog(Workflowtranlog obj)
        {
            return _WorkflowtranlogRespository.CreateWorkflowtranlog(obj);
        }

        public void DeleteWorkflowtranlog(int code)
        {
            _WorkflowtranlogRespository.DeleteWorkflowtranlog(code);
        }

        public List<Workflowtranlog> GetWorkflowtranlog()
        {
            return _WorkflowtranlogRespository.GetWorkflowtranlog();
        }

        public List<Workflowtranlog> GetWorkflowtranlogByCode(string code)
        {
            return _WorkflowtranlogRespository.GetWorkflowtranlogByCode(code);

        }

        public Workflowtranlog UpdateWorkflowtranlog(Workflowtranlog obj)
        {
            return _WorkflowtranlogRespository.UpdateWorkflowtranlog(obj);
        }
    }
}
