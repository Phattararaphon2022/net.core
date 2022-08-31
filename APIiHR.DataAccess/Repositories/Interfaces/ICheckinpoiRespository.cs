using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface ICheckinpoiRespository
    {
        List<Checkinpoi> GetCheckinpoi();
        List<Checkinpoi> GetCheckinpoiByCode(string code);

        Checkinpoi CreateCheckinpoi(Checkinpoi obj);

        Checkinpoi UpdateCheckinpoi(Checkinpoi obj);

        void DeleteCheckinpoi(int id);
    }
}
