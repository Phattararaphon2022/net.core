using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ITeammasterManager
    {
        List<Teammaster> GetTeammaster();
        List<Teammaster> GetTeammasterByCode(string code);
        Teammaster CreateTeammaster(Teammaster obj);
        Teammaster UpdateTeammaster(int id, Teammaster obj);
        void DeleteTeammaster(int code);
    }
}
