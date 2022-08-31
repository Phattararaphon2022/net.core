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
    public class CheckinpoiDataAccess : ICheckinpoiDataAccess
    {
        private ICheckinpoiRespository _CheckinpoiRespository;
        public CheckinpoiDataAccess(ICheckinpoiRespository CheckinpoiRepository)
        {
            _CheckinpoiRespository = CheckinpoiRepository;
        }
        public Checkinpoi CreateCheckinpoi(Checkinpoi obj)
        {
            return _CheckinpoiRespository.CreateCheckinpoi(obj);
        }

        public void DeleteCheckinpoi(int code)
        {
            _CheckinpoiRespository.DeleteCheckinpoi(code);
        }

        public List<Checkinpoi> GetCheckinpoi()
        {
            return _CheckinpoiRespository.GetCheckinpoi();
        }

        public List<Checkinpoi> GetCheckinpoiByCode(string code)
        {
            return _CheckinpoiRespository.GetCheckinpoiByCode(code);

        }

        public Checkinpoi UpdateCheckinpoi(Checkinpoi obj)
        {
            return _CheckinpoiRespository.UpdateCheckinpoi(obj);
        }
    }
}
