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
    public class TeammasterDataAccess : ITeammasterDataAccess
    {
        private ITeammasterRespository _TeammasterRespository;
        public TeammasterDataAccess(ITeammasterRespository TeammasterRepository)
        {
            _TeammasterRespository = TeammasterRepository;
        }
        public Teammaster CreateTeammaster(Teammaster obj)
        {
            return _TeammasterRespository.CreateTeammaster(obj);
        }

        public void DeleteTeammaster(int code)
        {
            _TeammasterRespository.DeleteTeammaster(code);
        }

        public List<Teammaster> GetTeammaster()
        {
            return _TeammasterRespository.GetTeammaster();
        }

        public List<Teammaster> GetTeammasterByCode(string code)
        {
            return _TeammasterRespository.GetTeammasterByCode(code);

        }

        public Teammaster UpdateTeammaster(Teammaster obj)
        {
            return _TeammasterRespository.UpdateTeammaster(obj);
        }
    }
}
