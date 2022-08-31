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
    public class SysmtappRespository : ISysmtappRespository
    {
        private DbSysmtappContext _DbSysmtappContext;
        public SysmtappRespository(DbSysmtappContext dbSysmtappContext)
        {
            _DbSysmtappContext = dbSysmtappContext;
        }
        public Sysmtapp CreateSysmtapp(Sysmtapp obj)
        {
            obj.recid = new int();            
            obj.sysmtapp_createdate = DateTime.Now;
            //obj.recid = 
            //obj.Sysmtapp_date = DateTime.Now;
                        
            _DbSysmtappContext.SysmtappTable.Add(obj);
            _DbSysmtappContext.SaveChanges();
            return obj;
        }

        public void DeleteSysmtapp(int id)
        {

            var items = _DbSysmtappContext.SysmtappTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysmtappContext.Remove(items.First());
                _DbSysmtappContext.SaveChanges();
            }
        }

        public List<Sysmtapp> GetSysmtapp()
        {
            return _DbSysmtappContext.SysmtappTable.ToList();
        }
        public List<Sysmtapp> GetSysmtappByCode(int code)
        {
            var items = _DbSysmtappContext.SysmtappTable.Where(item => item.recid == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysmtapp UpdateSysmtapp(Sysmtapp obj)
        {
            var items = _DbSysmtappContext.SysmtappTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysmtapp = items.FirstOrDefault();

            //Sysmtapp.sysmtapp_createdate = obj.sysmtapp_createdate;
            Sysmtapp.sysmtapp_namealian = obj.sysmtapp_namealian;
            Sysmtapp.sysmtapp_txdesc = obj.sysmtapp_txdesc;
            Sysmtapp.sysmtapp_status = obj.sysmtapp_status;
            Sysmtapp.sysmtapp_code = obj.sysmtapp_code;
            Sysmtapp.sysmtapp_nextmt = obj.sysmtapp_nextmt;
            Sysmtapp.sysmtapp_master = obj.sysmtapp_master;
            Sysmtapp.sysmtapp_nextmtrec = obj.sysmtapp_nextmtrec;


            _DbSysmtappContext.SaveChanges();
            return Sysmtapp;
        }
    }
}
