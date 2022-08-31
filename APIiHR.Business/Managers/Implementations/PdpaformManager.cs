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
    public class PdpaformManager : IPdpaformManager
    {
        private IPdpaformDataAccess _PdpaformDataAccess;
        public PdpaformManager(IPdpaformDataAccess PdpaformDataAccess)
        {
            _PdpaformDataAccess = PdpaformDataAccess;
        }

        public Pdpaform CreatePdpaform(Pdpaform obj)
        {
            return _PdpaformDataAccess.CreatePdpaform(obj);
        }

        public void DeletePdpaform(int code)
        {
            _PdpaformDataAccess.DeletePdpaform(code);
        }

        public List<Pdpaform> GetPdpaform()
        {
            return _PdpaformDataAccess.GetPdpaform();
        }

        public List<Pdpaform> GetPdpaformByCode(string code)
        {
            return _PdpaformDataAccess.GetPdpaformByCode(code);
        }

        public Pdpaform UpdatePdpaform(int id, Pdpaform obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _PdpaformDataAccess.UpdatePdpaform(obj);
        }
    }
}
