using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface ITeammasterRespository
    {
        List<Teammaster> GetTeammaster();
        List<Teammaster> GetTeammasterByCode(string code);

        Teammaster CreateTeammaster(Teammaster obj);

        Teammaster UpdateTeammaster(Teammaster obj);

        void DeleteTeammaster(int id);
    }
}
