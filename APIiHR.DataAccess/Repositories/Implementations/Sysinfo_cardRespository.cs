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
    public class Sysinfo_cardRespository : ISysinfo_cardRespository
    {
        private DbSysinfo_cardContext _DbSysinfo_cardContext;
        public Sysinfo_cardRespository(DbSysinfo_cardContext dbSysinfo_cardContext)
        {
            _DbSysinfo_cardContext = dbSysinfo_cardContext;
        }
        public Sysinfo_card CreateSysinfo_card(Sysinfo_card obj)
        {
            obj.recid = new int();
            obj.sysinfo_card_createdate = DateTime.Now;
            //obj.recid = 
            //obj.Sysinfo_card_date = DateTime.Now;          
            _DbSysinfo_cardContext.Sysinfo_cardTable.Add(obj);
            _DbSysinfo_cardContext.SaveChanges();
            return obj;
        }

        public void DeleteSysinfo_card(int id)
        {

            var items = _DbSysinfo_cardContext.Sysinfo_cardTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbSysinfo_cardContext.Remove(items.First());
                _DbSysinfo_cardContext.SaveChanges();
            }
        }

        public List<Sysinfo_card> GetSysinfo_card()
        {
            return _DbSysinfo_cardContext.Sysinfo_cardTable.ToList();
        }
        public List<Sysinfo_card> GetSysinfo_cardByCode(string code)
        {
            var items = _DbSysinfo_cardContext.Sysinfo_cardTable.Where(item => item.sysinfo_card_worker_code == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Sysinfo_card UpdateSysinfo_card(Sysinfo_card obj)
        {
            var items = _DbSysinfo_cardContext.Sysinfo_cardTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Sysinfo_card = items.FirstOrDefault();

            Sysinfo_card.sysinfo_card_createdate = obj.sysinfo_card_createdate;
            Sysinfo_card.sysinfo_card_namealian = obj.sysinfo_card_namealian;
            Sysinfo_card.sysinfo_card_worker_code = obj.sysinfo_card_worker_code;
            Sysinfo_card.sysinfo_card_idnum = obj.sysinfo_card_idnum;
            Sysinfo_card.sysinfo_card_expdate = obj.sysinfo_card_expdate;
            Sysinfo_card.sysinfo_card_status = obj.sysinfo_card_status;
            Sysinfo_card.sysinfo_card_from = obj.sysinfo_card_from;

            Sysinfo_card.sysinfo_card_reftran = obj.sysinfo_card_reftran;
            Sysinfo_card.sysinfo_card_refdim1 = obj.sysinfo_card_refdim1;
            Sysinfo_card.sysinfo_card_refdimrec = obj.sysinfo_card_refdimrec;

            _DbSysinfo_cardContext.SaveChanges();
            return Sysinfo_card;
        }
    }
}
