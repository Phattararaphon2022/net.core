using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ICheckinManager
    {
        List<Checkin> GetCheckin();
        List<Checkin> GetCheckinByCode(string code);
        Checkin CreateCheckin(Checkin obj);
        Checkin UpdateCheckin(int id, Checkin obj);
        void DeleteCheckin(int code);
    }
}
