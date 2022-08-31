using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface ICheckinpoiManager
    {
        List<Checkinpoi> GetCheckinpoi();
        List<Checkinpoi> GetCheckinpoiByCode(string code);
        Checkinpoi CreateCheckinpoi(Checkinpoi obj);
        Checkinpoi UpdateCheckinpoi(int id, Checkinpoi obj);
        void DeleteCheckinpoi(int code);
    }
}
