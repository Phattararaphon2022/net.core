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
    public class Sysmttask_linechkDataAccess : ISysmttask_linechkDataAccess
    {
        private ISysmttask_linechkRespository _Sysmttask_linechkRespository;
        public Sysmttask_linechkDataAccess(ISysmttask_linechkRespository Sysmttask_linechkRepository)
        {
            _Sysmttask_linechkRespository = Sysmttask_linechkRepository;
        }
        public Sysmttask_linechk CreateSysmttask_linechk(Sysmttask_linechk obj)
        {
            return _Sysmttask_linechkRespository.CreateSysmttask_linechk(obj);
        }

        public void DeleteSysmttask_linechk(int code)
        {
            _Sysmttask_linechkRespository.DeleteSysmttask_linechk(code);
        }

        public List<Sysmttask_linechk> GetSysmttask_linechk()
        {
            return _Sysmttask_linechkRespository.GetSysmttask_linechk();
        }

        public List<Sysmttask_linechk> GetSysmttask_linechkByCode(string code)
        {
            return _Sysmttask_linechkRespository.GetSysmttask_linechkByCode(code);

        }

        public Sysmttask_linechk UpdateSysmttask_linechk(Sysmttask_linechk obj)
        {
            return _Sysmttask_linechkRespository.UpdateSysmttask_linechk(obj);
        }
    }
}
