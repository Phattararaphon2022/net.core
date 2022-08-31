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
    public class TeamlineManager : ITeamlineManager
    {
        private ITeamlineDataAccess _TeamlineDataAccess;
        public TeamlineManager(ITeamlineDataAccess TeamlineDataAccess)
        {
            _TeamlineDataAccess = TeamlineDataAccess;
        }

        public Teamline CreateTeamline(Teamline obj)
        {
            return _TeamlineDataAccess.CreateTeamline(obj);
        }

        public void DeleteTeamline(int code)
        {
            _TeamlineDataAccess.DeleteTeamline(code);
        }
        public void DeleteTeamlineByCode(int code)
        {
            _TeamlineDataAccess.DeleteTeamlineByCode(code);
        }
        public void DeleteTeamLineObj(Teamline obj)
        {
            _TeamlineDataAccess.DeleteTeamLineObj(obj);
        }

        public List<Teamline> GetTeamline()
        {
            return _TeamlineDataAccess.GetTeamline();
        }

        public List<Teamline> GetTeamlineByCode(string code)
        {
            return _TeamlineDataAccess.GetTeamlineByCode(code);
        }
        public List<Teamline> GetTeamlineByCodeWK(string code)
        {
            return _TeamlineDataAccess.GetTeamlineByCodeWK(code);
        }

        public Teamline UpdateTeamline(int id, Teamline obj)
        {
            Console.WriteLine(id);
            obj.recid = id;

            if(obj.teamline_level == "delete")
            {
                _TeamlineDataAccess.DeleteTeamLineObj(obj);
                return obj;
            }
            else
            {
                return _TeamlineDataAccess.UpdateTeamline(obj);
            }
            
        }
    }
}
