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
    public class CheckinDataAccess : ICheckinDataAccess
    {
        private ICheckinRespository _CheckinRespository;
        public CheckinDataAccess(ICheckinRespository CheckinRepository)
        {
            _CheckinRespository = CheckinRepository;
        }
        public Checkin CreateCheckin(Checkin obj)
        {
            return _CheckinRespository.CreateCheckin(obj);
        }

        public void DeleteCheckin(int code)
        {
            _CheckinRespository.DeleteCheckin(code);
        }

        public List<Checkin> GetCheckin()
        {
            return _CheckinRespository.GetCheckin();
        }

        public List<Checkin> GetCheckinByCode(string code)
        {
            return _CheckinRespository.GetCheckinByCode(code);

        }

        public Checkin UpdateCheckin(Checkin obj)
        {
            return _CheckinRespository.UpdateCheckin(obj);
        }
    }
}
