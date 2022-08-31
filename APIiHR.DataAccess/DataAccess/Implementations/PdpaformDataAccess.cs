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
    public class PdpaformDataAccess : IPdpaformDataAccess
    {
        private IPdpaformRespository _PdpaformRespository;
        public PdpaformDataAccess(IPdpaformRespository PdpaformRepository)
        {
            _PdpaformRespository = PdpaformRepository;
        }
        public Pdpaform CreatePdpaform(Pdpaform obj)
        {
            return _PdpaformRespository.CreatePdpaform(obj);
        }

        public void DeletePdpaform(int code)
        {
            _PdpaformRespository.DeletePdpaform(code);
        }

        public List<Pdpaform> GetPdpaform()
        {
            return _PdpaformRespository.GetPdpaform();
        }

        public List<Pdpaform> GetPdpaformByCode(string code)
        {
            return _PdpaformRespository.GetPdpaformByCode(code);

        }

        public Pdpaform UpdatePdpaform(Pdpaform obj)
        {
            return _PdpaformRespository.UpdatePdpaform(obj);
        }
    }
}
