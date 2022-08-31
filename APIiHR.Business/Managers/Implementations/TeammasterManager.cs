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
    public class TeammasterManager : ITeammasterManager
    {
        private ITeammasterDataAccess _TeammasterDataAccess;
        public TeammasterManager(ITeammasterDataAccess TeammasterDataAccess)
        {
            _TeammasterDataAccess = TeammasterDataAccess;
        }

        public Teammaster CreateTeammaster(Teammaster obj)
        {
            return _TeammasterDataAccess.CreateTeammaster(obj);
        }

        public void DeleteTeammaster(int code)
        {
            _TeammasterDataAccess.DeleteTeammaster(code);
        }

        public List<Teammaster> GetTeammaster()
        {
            return _TeammasterDataAccess.GetTeammaster();
        }

        public List<Teammaster> GetTeammasterByCode(string code)
        {
            return _TeammasterDataAccess.GetTeammasterByCode(code);
        }

        public Teammaster UpdateTeammaster(int id, Teammaster obj)
        {
           // Console.WriteLine(id);
            obj.recid = id;
            return _TeammasterDataAccess.UpdateTeammaster(obj);
        }
    }
}
