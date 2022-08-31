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
    public class Sysmttask_linechkManager : ISysmttask_linechkManager
    {
        private ISysmttask_linechkDataAccess _Sysmttask_linechkDataAccess;
        public Sysmttask_linechkManager(ISysmttask_linechkDataAccess Sysmttask_linechkDataAccess)
        {
            _Sysmttask_linechkDataAccess = Sysmttask_linechkDataAccess;
        }

        public Sysmttask_linechk CreateSysmttask_linechk(Sysmttask_linechk obj)
        {
            return _Sysmttask_linechkDataAccess.CreateSysmttask_linechk(obj);
        }

        public void DeleteSysmttask_linechk(int code)
        {
            _Sysmttask_linechkDataAccess.DeleteSysmttask_linechk(code);
        }

        public List<Sysmttask_linechk> GetSysmttask_linechk()
        {
            return _Sysmttask_linechkDataAccess.GetSysmttask_linechk();
        }

        public List<Sysmttask_linechk> GetSysmttask_linechkByCode(string code)
        {
            return _Sysmttask_linechkDataAccess.GetSysmttask_linechkByCode(code);
        }

        public Sysmttask_linechk UpdateSysmttask_linechk(int id, Sysmttask_linechk obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _Sysmttask_linechkDataAccess.UpdateSysmttask_linechk(obj);
        }
    }
}
