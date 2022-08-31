using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IAuthenManager
    {
        List<Authen> GetAuthen();
        List<Authen> GetAuthenByCode(string code);
        Authen CreateAuthen(Authen obj);
        Authen UpdateAuthen(int id, Authen obj);
        void DeleteAuthen(int code);
    }
}
