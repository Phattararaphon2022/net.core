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
    public class AunthenManager : IAuthenManager
    {
        private IAuthenDataAccess _AuthenDataAccess;
        public AunthenManager(IAuthenDataAccess AuthenDataAccess)
        {
            _AuthenDataAccess = AuthenDataAccess;
        }

        public Authen CreateAuthen(Authen obj)
        {
            return _AuthenDataAccess.CreateAuthen(obj);
        }

        public void DeleteAuthen(int code)
        {
            _AuthenDataAccess.DeleteAuthen(code);
        }

        public List<Authen> GetAuthen()
        {
            return _AuthenDataAccess.GetAuthen();
        }

        public List<Authen> GetAuthenByCode(string code)
        {
            return _AuthenDataAccess.GetAuthenByCode(code);
        }

        public Authen UpdateAuthen(int id, Authen obj)
        {
            Console.WriteLine(id);
            obj.CompID = id.ToString();
            //obj.EmpID = id.ToString();
            return _AuthenDataAccess.UpdateAuthen(obj);
        }
    }
}
