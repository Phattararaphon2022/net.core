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
    public class SysleavetypeDataAccess : ISysleavetypeDataAccess
    {
        private ISysleavetypeRespository _SysleavetypeRespository;
        public SysleavetypeDataAccess(ISysleavetypeRespository SysleavetypeRepository)
        {
            _SysleavetypeRespository = SysleavetypeRepository;
        }
        public Sysleavetype CreateSysleavetype(Sysleavetype obj)
        {
            return _SysleavetypeRespository.CreateSysleavetype(obj);
        }

        public void DeleteSysleavetype(int code)
        {
            _SysleavetypeRespository.DeleteSysleavetype(code);
        }

        public List<Sysleavetype> GetSysleavetype()
        {
            return _SysleavetypeRespository.GetSysleavetype();
        }

        public List<Sysleavetype> GetSysleavetypeByCode(int code)
        {
            return _SysleavetypeRespository.GetSysleavetypeByCode(code);

        }

        public Sysleavetype UpdateSysleavetype(Sysleavetype obj)
        {
            return _SysleavetypeRespository.UpdateSysleavetype(obj);
        }
    }
}
