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
    public class ApptransManager : IApptransManager
    {
        private IApptransDataAccess _ApptransDataAccess;
        public ApptransManager(IApptransDataAccess ApptransDataAccess)
        {
            _ApptransDataAccess = ApptransDataAccess;
        }

        public Apptrans CreateApptrans(Apptrans obj)
        {
            return _ApptransDataAccess.CreateApptrans(obj);
        }

        public void DeleteApptrans(int code)
        {
            _ApptransDataAccess.DeleteApptrans(code);
        }

        public List<Apptrans> GetApptrans()
        {
            return _ApptransDataAccess.GetApptrans();
        }

        public List<Apptrans> GetApptransByCode(string code)
        {
            return _ApptransDataAccess.GetApptransByCode(code);
        }

        public Apptrans UpdateApptrans(int id, Apptrans obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _ApptransDataAccess.UpdateApptrans(obj);
        }
    }
}
