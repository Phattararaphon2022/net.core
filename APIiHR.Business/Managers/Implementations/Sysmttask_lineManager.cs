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
    public class Sysmttask_lineManager : ISysmttask_lineManager
    {
        private ISysmttask_lineDataAccess _Sysmttask_lineDataAccess;
        public Sysmttask_lineManager(ISysmttask_lineDataAccess Sysmttask_lineDataAccess)
        {
            _Sysmttask_lineDataAccess = Sysmttask_lineDataAccess;
        }

        public Sysmttask_line CreateSysmttask_line(Sysmttask_line obj)
        {
            return _Sysmttask_lineDataAccess.CreateSysmttask_line(obj);
        }

        public void DeleteSysmttask_line(int code)
        {
            _Sysmttask_lineDataAccess.DeleteSysmttask_line(code);
        }

        public List<Sysmttask_line> GetSysmttask_line()
        {
            return _Sysmttask_lineDataAccess.GetSysmttask_line();
        }

        public List<Sysmttask_line> GetSysmttask_lineByCode(string code)
        {
            return _Sysmttask_lineDataAccess.GetSysmttask_lineByCode(code);
        }

        public Sysmttask_line UpdateSysmttask_line(int id, Sysmttask_line obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _Sysmttask_lineDataAccess.UpdateSysmttask_line(obj);
        }
    }
}
