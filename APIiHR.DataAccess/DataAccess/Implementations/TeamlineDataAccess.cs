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
    public class TeamlineDataAccess : ITeamlineDataAccess
    {
        private ITeamlineRespository _TeamlineRespository;
        public TeamlineDataAccess(ITeamlineRespository TeamlineRepository)
        {
            _TeamlineRespository = TeamlineRepository;
        }
        public Teamline CreateTeamline(Teamline obj)
        {
            return _TeamlineRespository.CreateTeamline(obj);
        }

        public void DeleteTeamline(int code)
        {
            _TeamlineRespository.DeleteTeamline(code);
        }
        public void DeleteTeamlineByCode(int code)
        {
            _TeamlineRespository.DeleteTeamlineByCode(code);
        }

        public void DeleteTeamLineObj(Teamline obj)
        {
            _TeamlineRespository.DeleteTeamLineObj(obj);
        }

        public List<Teamline> GetTeamline()
        {
            return _TeamlineRespository.GetTeamline();
        }

        public List<Teamline> GetTeamlineByCode(string code)
        {
            return _TeamlineRespository.GetTeamlineByCode(code);

        }
        public List<Teamline> GetTeamlineByCodeWK(string code)
        {
            return _TeamlineRespository.GetTeamlineByCodeWK(code);

        }

        public Teamline UpdateTeamline(Teamline obj)
        {
            return _TeamlineRespository.UpdateTeamline(obj);
        }
    }
}
