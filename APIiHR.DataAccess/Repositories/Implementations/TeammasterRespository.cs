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
    public class TeammasterRespository : ITeammasterRespository
    {
        private DbTeammasterContext _DbTeammasterContext;
        public TeammasterRespository(DbTeammasterContext dbTeammasterContext)
        {
            _DbTeammasterContext = dbTeammasterContext;
        }
        public Teammaster CreateTeammaster(Teammaster obj)
        {
            obj.recid = new int();
            obj.teammaster_createdate = DateTime.Now;
            obj.teammaster_modifydate = DateTime.Now;
            _DbTeammasterContext.TeammasterTable.Add(obj);
            _DbTeammasterContext.SaveChanges();
            return obj;
        }

        public void DeleteTeammaster(int id)
        {

            var items = _DbTeammasterContext.TeammasterTable.Where(item => item.recid == id);
            

            if (items.Any())
            {
                _DbTeammasterContext.Remove(items.First());
                _DbTeammasterContext.SaveChanges();
            }
        }

        public List<Teammaster> GetTeammaster()
        {
            return _DbTeammasterContext.TeammasterTable.ToList();
        }
        public List<Teammaster> GetTeammasterByCode(string code)
        {
            var items = _DbTeammasterContext.TeammasterTable.Where(item => item.teammaster_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Teammaster UpdateTeammaster(Teammaster obj)
        {
            var items = _DbTeammasterContext.TeammasterTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Teammaster = items.FirstOrDefault();

            Teammaster.teammaster_modifydate = DateTime.Now;
            Teammaster.teammaster_worker_code = obj.teammaster_worker_code;
            Teammaster.teammaster_namealian = obj.teammaster_namealian;
            Teammaster.teammaster_txdesc = obj.teammaster_txdesc;
            Teammaster.teammaster_status = obj.teammaster_status;
            Teammaster.teammaster_code = obj.teammaster_code;

            _DbTeammasterContext.SaveChanges();
            return Teammaster;
        }
    }
}
