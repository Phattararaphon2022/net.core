using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Implementations
{
    public class SysmttaskDataAccess : ISysmttaskDataAccess
    {
        private ISysmttaskRespository _SysmttaskRespository;
        public SysmttaskDataAccess(ISysmttaskRespository SysmttaskRepository)
        {
            _SysmttaskRespository = SysmttaskRepository;
        }
        public Sysmttask CreateSysmttask(Sysmttask obj)
        {
            return _SysmttaskRespository.CreateSysmttask(obj);
        }

        public void DeleteSysmttask(int code)
        {
            _SysmttaskRespository.DeleteSysmttask(code);
        }

        public List<Sysmttask> GetSysmttask()
        {
            return _SysmttaskRespository.GetSysmttask();
        }

        public List<Sysmttask> GetSysmttaskByCode(string code)
        {
            return _SysmttaskRespository.GetSysmttaskByCode(code);

        }

        public Sysmttask UpdateSysmttask(Sysmttask obj)
        {
            return _SysmttaskRespository.UpdateSysmttask(obj);
        }
    }
}
