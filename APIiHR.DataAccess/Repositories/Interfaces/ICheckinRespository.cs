using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface ICheckinRespository
    {
        List<Checkin> GetCheckin();
        List<Checkin> GetCheckinByCode(string code);

        Checkin CreateCheckin(Checkin obj);

        Checkin UpdateCheckin(Checkin obj);

        void DeleteCheckin(int id);
    }
}
