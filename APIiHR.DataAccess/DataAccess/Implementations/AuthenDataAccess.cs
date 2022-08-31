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
    public class AuthenDataAccess : IAuthenDataAccess
    {
        private IAuthenRespository _IAuthenRespository;
        public AuthenDataAccess(IAuthenRespository AuthenRespository)
        {
            _IAuthenRespository = AuthenRespository;
        }
        public Authen CreateAuthen(Authen obj)
        {
            return _IAuthenRespository.CreateAuthen(obj);
        }

        public void DeleteAuthen(int code)
        {
            _IAuthenRespository.DeleteAuthen(code);
        }

        public List<Authen> GetAuthen()
        {
            return _IAuthenRespository.GetAuthen();
        }

        public List<Authen> GetAuthenByCode(string code)
        {
            return _IAuthenRespository.GetAuthenByCode(code);

        }

        public Authen UpdateAuthen(Authen obj)
        {
            return _IAuthenRespository.UpdateAuthen(obj);
        }
    }
}
