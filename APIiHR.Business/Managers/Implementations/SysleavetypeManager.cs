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
    public class SysleavetypeManager : ISysleavetypeManager
    {
        private ISysleavetypeDataAccess _SysleavetypeDataAccess;
        public SysleavetypeManager(ISysleavetypeDataAccess SysleavetypeDataAccess)
        {
            _SysleavetypeDataAccess = SysleavetypeDataAccess;
        }

        public Sysleavetype CreateSysleavetype(Sysleavetype obj)
        {
            return _SysleavetypeDataAccess.CreateSysleavetype(obj);
        }

        public void DeleteSysleavetype(int code)
        {
            _SysleavetypeDataAccess.DeleteSysleavetype(code);
        }

        public List<Sysleavetype> GetSysleavetype()
        {
            return _SysleavetypeDataAccess.GetSysleavetype();
        }

        public List<Sysleavetype> GetSysleavetypeByCode(int code)
        {
            return _SysleavetypeDataAccess.GetSysleavetypeByCode(code);
        }

        public Sysleavetype UpdateSysleavetype(int id, Sysleavetype obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _SysleavetypeDataAccess.UpdateSysleavetype(obj);
        }
    }
}
