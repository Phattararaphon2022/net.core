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
    public class SyslocationManager : ISyslocationManager
    {
        private ISyslocationDataAccess _SyslocationDataAccess;
        public SyslocationManager(ISyslocationDataAccess SyslocationDataAccess)
        {
            _SyslocationDataAccess = SyslocationDataAccess;
        }

        public Syslocation CreateSyslocation(Syslocation obj)
        {
            return _SyslocationDataAccess.CreateSyslocation(obj);
        }

        public void DeleteSyslocation(int code)
        {
            _SyslocationDataAccess.DeleteSyslocation(code);
        }

        public List<Syslocation> GetSyslocation()
        {
            return _SyslocationDataAccess.GetSyslocation();
        }

        public List<Syslocation> GetSyslocationByCode(string code)
        {
            return _SyslocationDataAccess.GetSyslocationByCode(code);
        }

        public Syslocation UpdateSyslocation(int id, Syslocation obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _SyslocationDataAccess.UpdateSyslocation(obj);
        }
    }
}
