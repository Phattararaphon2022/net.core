using APIiHR.Common;
using APIiHR.DataAccess.DatabaseContexts;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Implementations
{
    public class TeamlineRespository : ITeamlineRespository
    {
        private DbTeamlineContext _DbTeamlineContext;
        public TeamlineRespository(DbTeamlineContext dbTeamlineContext)
        {
            _DbTeamlineContext = dbTeamlineContext;
        }
        public Teamline CreateTeamline(Teamline obj)
        {
            obj.recid = new int();
            obj.teamline_createdate = DateTime.Now;
            obj.teamline_modifydate = DateTime.Now;
            obj.teamline_startdate = DateTime.Now;
            _DbTeamlineContext.TeamlineTable.Add(obj);
            _DbTeamlineContext.SaveChanges();
            return obj;
        }

        public void DeleteTeamline(int id)
        {

            var items = _DbTeamlineContext.TeamlineTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbTeamlineContext.Remove(items.First());
                _DbTeamlineContext.SaveChanges();
            }
        }
        public void DeleteTeamLineObj(Teamline obj)
        {
            var items = _DbTeamlineContext.TeamlineTable.Where(item => item.teamline_codemaster == obj.teamline_codemaster
            && item.teamline_workermaster == obj.teamline_workermaster);
            if (items.Any())
            {
                _DbTeamlineContext.RemoveRange(items);
                _DbTeamlineContext.SaveChanges();
            }
        }
        public void DeleteTeamlineByCode(int code)
        {

            var items = _DbTeamlineContext.TeamlineTable.Where(item => item.teamline_status == code);

            

            if (items.Any())
            {
                _DbTeamlineContext.RemoveRange(items);                
                _DbTeamlineContext.SaveChanges();
            }
        }

        public List<Teamline> GetTeamline()
        {
            return _DbTeamlineContext.TeamlineTable.ToList();
        }
        public List<Teamline> GetTeamlineByCode(string code)
        {
            var items = _DbTeamlineContext.TeamlineTable.Where(item => item.teamline_codemaster == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public List<Teamline> GetTeamlineByCodeWK(string code)
        {
            var items = _DbTeamlineContext.TeamlineTable.Where(item => item.teamline_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Teamline UpdateTeamline(Teamline obj)
        {
            var items = _DbTeamlineContext.TeamlineTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Teamline = items.FirstOrDefault();

            Teamline.teamline_worker_code = obj.teamline_worker_code;
            Teamline.teamline_namealian = obj.teamline_namealian;
            Teamline.teamline_txdesc = obj.teamline_txdesc;
            Teamline.teamline_status = obj.teamline_status;
            Teamline.teamline_codemaster = obj.teamline_codemaster;
            Teamline.teamline_level = obj.teamline_level;
            Teamline.teamline_startdate = obj.teamline_startdate;
            Teamline.teamline_enddate = obj.teamline_enddate;
            Teamline.teamline_worker_code = obj.teamline_worker_code;


            _DbTeamlineContext.SaveChanges();
            return Teamline;
        }
    }
}
