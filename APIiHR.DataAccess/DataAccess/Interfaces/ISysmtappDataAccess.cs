using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Interfaces
{
    public interface ISysmtappDataAccess
    {
        List<Sysmtapp> GetSysmtapp();
        List<Sysmtapp> GetSysmtappByCode(int code);
        Sysmtapp CreateSysmtapp(Sysmtapp obj);
        Sysmtapp UpdateSysmtapp(Sysmtapp obj);
        void DeleteSysmtapp(int code);
    }
}
