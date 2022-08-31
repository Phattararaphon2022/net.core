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
    public class Sysmttask_lineDataAccess : ISysmttask_lineDataAccess
    {
        private ISysmttask_lineRespository _Sysmttask_lineRespository;
        public Sysmttask_lineDataAccess(ISysmttask_lineRespository Sysmttask_lineRepository)
        {
            _Sysmttask_lineRespository = Sysmttask_lineRepository;
        }
        public Sysmttask_line CreateSysmttask_line(Sysmttask_line obj)
        {
            return _Sysmttask_lineRespository.CreateSysmttask_line(obj);
        }

        public void DeleteSysmttask_line(int code)
        {
            _Sysmttask_lineRespository.DeleteSysmttask_line(code);
        }

        public List<Sysmttask_line> GetSysmttask_line()
        {
            return _Sysmttask_lineRespository.GetSysmttask_line();
        }

        public List<Sysmttask_line> GetSysmttask_lineByCode(string code)
        {
            return _Sysmttask_lineRespository.GetSysmttask_lineByCode(code);

        }

        public Sysmttask_line UpdateSysmttask_line(Sysmttask_line obj)
        {
            return _Sysmttask_lineRespository.UpdateSysmttask_line(obj);
        }
    }
}
