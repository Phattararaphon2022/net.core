using APIiHR.Common;
using APIiHR.DataAccess.DatabaseContexts;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Implementations
{
    public class PdpaformRespository : IPdpaformRespository
    {
        private DbPdpaformContext _DbPdpaformContext;
        public PdpaformRespository(DbPdpaformContext dbPdpaformContext)
        {
            _DbPdpaformContext = dbPdpaformContext;
        }
        public Pdpaform CreatePdpaform(Pdpaform obj)
        {
            obj.recid = new int();
            obj.pdpaform_createdate = DateTime.Now;
            //obj.recid = 
            //obj.Pdpaform_date = DateTime.Now;
           
            _DbPdpaformContext.PdpaformTable.Add(obj);
            _DbPdpaformContext.SaveChanges();
            return obj;
        }

        public void DeletePdpaform(int id)
        {

            var items = _DbPdpaformContext.PdpaformTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbPdpaformContext.Remove(items.First());
                _DbPdpaformContext.SaveChanges();
            }
        }

        public List<Pdpaform> GetPdpaform()
        {
            return _DbPdpaformContext.PdpaformTable.ToList();
        }
        public List<Pdpaform> GetPdpaformByCode(string code)
        {
            var items = _DbPdpaformContext.PdpaformTable.Where(item => item.pdpaform_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Pdpaform UpdatePdpaform(Pdpaform obj)
        {
            var items = _DbPdpaformContext.PdpaformTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Pdpaform = items.FirstOrDefault();

            Pdpaform.pdpaform_createdate = obj.pdpaform_createdate;
            Pdpaform.pdpaform_modifydate = DateTime.Now;
            Pdpaform.pdpaform_worker_code = obj.pdpaform_worker_code;
            Pdpaform.pdpaform_refidfileatt = obj.pdpaform_refidfileatt;
            Pdpaform.pdpaform_refidapp = obj.pdpaform_refidapp;
            Pdpaform.pdpaform_startappcode = obj.pdpaform_startappcode;
            Pdpaform.pdpaform_emailadd = obj.pdpaform_emailadd;
            Pdpaform.pdpaform_infotype1 = obj.pdpaform_infotype1;
            Pdpaform.pdpaform_infotype2 = obj.pdpaform_infotype2;
            Pdpaform.pdpaform_txdesc = obj.pdpaform_txdesc;
            Pdpaform.pdpaform_person = obj.pdpaform_person;
            Pdpaform.pdpaform_fname = obj.pdpaform_fname;
            Pdpaform.pdpaform_lname = obj.pdpaform_lname;
            Pdpaform.pdpaform_status = obj.pdpaform_status;


            _DbPdpaformContext.SaveChanges();
            return Pdpaform;
        }
    }
}
