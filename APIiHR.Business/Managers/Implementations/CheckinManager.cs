using APIiHR.Business.Managers.Interfaces;
using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Implementations
{
    public class CheckinManager : ICheckinManager
    {
        private ICheckinDataAccess _CheckinDataAccess;
        public CheckinManager(ICheckinDataAccess CheckinDataAccess)
        {
            _CheckinDataAccess = CheckinDataAccess;
        }

        public Checkin CreateCheckin(Checkin obj)
        {
            return _CheckinDataAccess.CreateCheckin(obj);
        }

        public void DeleteCheckin(int code)
        {
            _CheckinDataAccess.DeleteCheckin(code);
        }

        public List<Checkin> GetCheckin()
        {
            return _CheckinDataAccess.GetCheckin();
        }

        public List<Checkin> GetCheckinByCode(string code)
        {
            return _CheckinDataAccess.GetCheckinByCode(code);
        }

        public Checkin UpdateCheckin(int id, Checkin obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _CheckinDataAccess.UpdateCheckin(obj);
        }
    }
}
