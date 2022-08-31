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
    public class CheckinpoiManager : ICheckinpoiManager
    {
        private ICheckinpoiDataAccess _CheckinpoiDataAccess;
        public CheckinpoiManager(ICheckinpoiDataAccess CheckinpoiDataAccess)
        {
            _CheckinpoiDataAccess = CheckinpoiDataAccess;
        }

        public Checkinpoi CreateCheckinpoi(Checkinpoi obj)
        {
            return _CheckinpoiDataAccess.CreateCheckinpoi(obj);
        }

        public void DeleteCheckinpoi(int code)
        {
            _CheckinpoiDataAccess.DeleteCheckinpoi(code);
        }

        public List<Checkinpoi> GetCheckinpoi()
        {
            return _CheckinpoiDataAccess.GetCheckinpoi();
        }

        public List<Checkinpoi> GetCheckinpoiByCode(string code)
        {
            return _CheckinpoiDataAccess.GetCheckinpoiByCode(code);
        }

        public Checkinpoi UpdateCheckinpoi(int id, Checkinpoi obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _CheckinpoiDataAccess.UpdateCheckinpoi(obj);
        }
    }
}
