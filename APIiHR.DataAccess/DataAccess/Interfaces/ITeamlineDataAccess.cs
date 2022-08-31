using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ITeamlineDataAccess
    {
        List<Teamline> GetTeamline();
        List<Teamline> GetTeamlineByCode(string code);
        List<Teamline> GetTeamlineByCodeWK(string code);
        Teamline CreateTeamline(Teamline obj);
        Teamline UpdateTeamline(Teamline obj);
        void DeleteTeamline(int code);
        void DeleteTeamlineByCode(int code);
        void DeleteTeamLineObj(Teamline obj);

    }
}
