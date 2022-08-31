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
    public class SysleavetypeRespository : ISysleavetypeRespository
    {
        private DbSysleavetypeContext _DbSysleavetypeContext;
        public SysleavetypeRespository(DbSysleavetypeContext dbSysleavetypeContext)
        {
            _DbSysleavetypeContext = dbSysleavetypeContext;
        }
        public Sysleavetype CreateSysleavetype(Sysleavetype obj)
        {
            obj.recid = new int();
            obj.sysleavetype_createdate = DateTime.Now;
            //obj.recid = 
            //obj.Sysleavetype_date = DateTime.Now;            
            _DbSysleavetypeContext.SysleavetypeTable.Add(obj);
            _DbSysleavetypeContext.SaveChanges();
            return obj;
        }

        public void DeleteSysleavetype(int id)
        {

            var items = _DbSysleavetypeContext.SysleavetypeTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysleavetypeContext.Remove(items.First());
                _DbSysleavetypeContext.SaveChanges();
            }
        }

        public List<Sysleavetype> GetSysleavetype()
        {
            return _DbSysleavetypeContext.SysleavetypeTable.ToList();
        }
        public List<Sysleavetype> GetSysleavetypeByCode(int code)
        {
            var items = _DbSysleavetypeContext.SysleavetypeTable.Where(item => item.recid == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysleavetype UpdateSysleavetype(Sysleavetype obj)
        {
            var items = _DbSysleavetypeContext.SysleavetypeTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysleavetype = items.FirstOrDefault();

            Sysleavetype.sysleavetype_createdate = obj.sysleavetype_createdate;
            Sysleavetype.sysleavetype_txdesc = obj.sysleavetype_txdesc;
            Sysleavetype.sysleavetype_refpoli = obj.sysleavetype_refpoli;
            Sysleavetype.sysleavetype_comuser = obj.sysleavetype_comuser;
            Sysleavetype.sysleavetype_maxdays = obj.sysleavetype_maxdays;
            Sysleavetype.sysleavetype_refcode = obj.sysleavetype_refcode;

            _DbSysleavetypeContext.SaveChanges();
            return Sysleavetype;
        }
    }
}
