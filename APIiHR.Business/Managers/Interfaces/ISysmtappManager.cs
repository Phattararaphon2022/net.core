using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ISysmtappManager
    {
        List<Sysmtapp> GetSysmtapp();
        List<Sysmtapp> GetSysmtappByCode(int code);
        Sysmtapp CreateSysmtapp(Sysmtapp obj);
        Sysmtapp UpdateSysmtapp(int id, Sysmtapp obj);
        void DeleteSysmtapp(int code);
    }
}
