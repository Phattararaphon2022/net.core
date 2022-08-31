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
    public class SysmttaskManager : ISysmttaskManager
    {
        private ISysmttaskDataAccess _SysmttaskDataAccess;
        public SysmttaskManager(ISysmttaskDataAccess SysmttaskDataAccess)
        {
            _SysmttaskDataAccess = SysmttaskDataAccess;
        }

        public Sysmttask CreateSysmttask(Sysmttask obj)
        {
            return _SysmttaskDataAccess.CreateSysmttask(obj);
        }

        public void DeleteSysmttask(int code)
        {
            _SysmttaskDataAccess.DeleteSysmttask(code);
        }

        public List<Sysmttask> GetSysmttask()
        {
            return _SysmttaskDataAccess.GetSysmttask();
        }

        public List<Sysmttask> GetSysmttaskByCode(string code)
        {
            return _SysmttaskDataAccess.GetSysmttaskByCode(code);
        }

        public Sysmttask UpdateSysmttask(int id, Sysmttask obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _SysmttaskDataAccess.UpdateSysmttask(obj);
        }
    }
}
