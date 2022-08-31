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
    public class SysmtappManager : ISysmtappManager
    {
        private ISysmtappDataAccess _SysmtappDataAccess;
        public SysmtappManager(ISysmtappDataAccess SysmtappDataAccess)
        {
            _SysmtappDataAccess = SysmtappDataAccess;
        }

        public Sysmtapp CreateSysmtapp(Sysmtapp obj)
        {
            return _SysmtappDataAccess.CreateSysmtapp(obj);
        }

        public void DeleteSysmtapp(int code)
        {
            _SysmtappDataAccess.DeleteSysmtapp(code);
        }

        public List<Sysmtapp> GetSysmtapp()
        {
            return _SysmtappDataAccess.GetSysmtapp();
        }

        public List<Sysmtapp> GetSysmtappByCode(int code)
        {
            return _SysmtappDataAccess.GetSysmtappByCode(code);
        }

        public Sysmtapp UpdateSysmtapp(int id, Sysmtapp obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _SysmtappDataAccess.UpdateSysmtapp(obj);
        }
    }
}
