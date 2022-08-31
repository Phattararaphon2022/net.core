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
    public class WorkflowtranDataAccess : IWorkflowtranDataAccess
    {
        private IWorkflowtranRespository _WorkflowtranRespository;
        public WorkflowtranDataAccess(IWorkflowtranRespository WorkflowtranRepository)
        {
            _WorkflowtranRespository = WorkflowtranRepository;
        }
        public Workflowtran CreateWorkflowtran(Workflowtran obj)
        {
            return _WorkflowtranRespository.CreateWorkflowtran(obj);
        }

        public void DeleteWorkflowtran(int code)
        {
            _WorkflowtranRespository.DeleteWorkflowtran(code);
        }

        public List<Workflowtran> GetWorkflowtran()
        {
            return _WorkflowtranRespository.GetWorkflowtran();
        }

        public List<Workflowtran> GetWorkflowtranByCode(int code)
        {
            return _WorkflowtranRespository.GetWorkflowtranByCode(code);

        }

        public Workflowtran UpdateWorkflowtran(Workflowtran obj)
        {
            return _WorkflowtranRespository.UpdateWorkflowtran(obj);
        }
    }
}
