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
    public class ApptransDataAccess : IApptransDataAccess
    {
        private IApptransRespository _ApptransRespository;
        public ApptransDataAccess(IApptransRespository ApptransRepository)
        {
            _ApptransRespository = ApptransRepository;
        }
        public Apptrans CreateApptrans(Apptrans obj)
        {
            return _ApptransRespository.CreateApptrans(obj);
        }

        public void DeleteApptrans(int code)
        {
            _ApptransRespository.DeleteApptrans(code);
        }

        public List<Apptrans> GetApptrans()
        {
            return _ApptransRespository.GetApptrans();
        }

        public List<Apptrans> GetApptransByCode(string code)
        {
            return _ApptransRespository.GetApptransByCode(code);

        }

        public Apptrans UpdateApptrans(Apptrans obj)
        {
            return _ApptransRespository.UpdateApptrans(obj);
        }
    }
}
