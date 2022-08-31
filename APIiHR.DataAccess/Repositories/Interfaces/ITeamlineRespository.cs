using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface ITeamlineRespository
    {
        List<Teamline> GetTeamline();
        List<Teamline> GetTeamlineByCode(string code);
        List<Teamline> GetTeamlineByCodeWK(string code);

        Teamline CreateTeamline(Teamline obj);

        Teamline UpdateTeamline(Teamline obj);

        void DeleteTeamLineObj(Teamline obj);

        void DeleteTeamline(int id);
        void DeleteTeamlineByCode(int code);
    }
}
