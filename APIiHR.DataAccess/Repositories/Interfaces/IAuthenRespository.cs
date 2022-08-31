using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface IAuthenRespository
    {
        List<Authen> GetAuthen();
        List<Authen> GetAuthenByCode(string code);

        Authen CreateAuthen(Authen obj);

        Authen UpdateAuthen(Authen obj);

        void DeleteAuthen(int id);
    }
}
