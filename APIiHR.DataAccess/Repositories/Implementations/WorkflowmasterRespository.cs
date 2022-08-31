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
    public class WorkflowmasterRespository : IWorkflowmasterRespository
    {
        private DbWorkflowmasterContext _DbWorkflowmasterContext;
        public WorkflowmasterRespository(DbWorkflowmasterContext dbWorkflowmasterContext)
        {
            _DbWorkflowmasterContext = dbWorkflowmasterContext;
        }
        public Workflowmaster CreateWorkflowmaster(Workflowmaster obj)
        {            
            Workflowmaster item;
            item = obj;
            /*
            do
            {
                switch(i)
                {
                    case 0: obj.workflowmaster_group = "ลากิจตัดสาย";                        
                            break;
                    case 1:obj.workflowmaster_group = "ลากิจ";
                        break;
                    case 2: obj.workflowmaster_group = "ลาเพื่อรับราชการทหาร";
                        break;
                    case 3: obj.workflowmaster_group = "ลาพักร้อน";
                        break;
                    case 4: obj.workflowmaster_group = "ลาคลอด1";
                        break;
                    case 5: obj.workflowmaster_group = "ลาคลอด2";
                        break;
                    case 6: obj.workflowmaster_group = "ลาคลอด3";
                        break;
                    case 7: obj.workflowmaster_group = "ลาอุปสมบท";
                        break;
                    case 8: obj.workflowmaster_group = "ลาป่วย";
                        break;
                    case 9: obj.workflowmaster_group = "ลาเพื่อฝึกอบรม";
                        break;
                    case 10: obj.workflowmaster_group = "ป่วยในงาน";
                        break;
                    case 11: obj.workflowmaster_group = "ขอลางาน";
                        break;
                    case 12: obj.workflowmaster_group = "ขอทำโอที";
                        break;
                    case 13: obj.workflowmaster_group = "ลงเวลาทำงาน";
                        break;
                    case 14: obj.workflowmaster_group = "ขออนุมัติเปลี่ยนประเภทวัน";
                        break;
                    case 15: obj.workflowmaster_group = "ขออนุมัติเปลี่ยนกะ";
                        break;
                    case 16: obj.workflowmaster_group = "EditInformation";
                        break;
                    case 17: obj.workflowmaster_group = "ลาป่วยเนื่องจากการทำงาน";
                        break;
                }
                obj.workflowmaster_refdim1 = i.ToString();
                obj.recid = new int();
                obj.workflowmaster_createdate = DateTime.Now;
                obj.workflowmaster_process = false;
                //obj.recid = 
                //obj.Workflowmaster_date = DateTime.Now;            
                _DbWorkflowmasterContext.WorkflowmasterTable.Add(obj);
                _DbWorkflowmasterContext.SaveChanges();
                i++;
            } while (i < 18);
            */
            obj.workflowmaster_createdate = DateTime.Now;
            _DbWorkflowmasterContext.WorkflowmasterTable.Add(obj);
            _DbWorkflowmasterContext.SaveChanges();

            return obj;

        }

        public void DeleteWorkflowmaster(int id)
        {

            var items = _DbWorkflowmasterContext.WorkflowmasterTable.Where(item => item.recid == id);

            if (items.Any())
            {                
                _DbWorkflowmasterContext.Remove(items.First());
                _DbWorkflowmasterContext.SaveChanges();
            }
        }
        public void DeleteWorkflowmastercode(string id)
        {
            Console.WriteLine(id);
            var items = _DbWorkflowmasterContext.WorkflowmasterTable.Where(item => item.workflowmaster_refgroup == id);

            foreach (var row in items)
            {
                _DbWorkflowmasterContext.Remove(row);
            }
            _DbWorkflowmasterContext.SaveChanges();
            /*
            if (items.Any())
            {
                _DbWorkflowmasterContext.Remove(items.First());
                _DbWorkflowmasterContext.SaveChanges();
            }
            */
        }


        public List<Workflowmaster> GetWorkflowmaster()
        {
            return _DbWorkflowmasterContext.WorkflowmasterTable.ToList();
        }
        public List<Workflowmaster> GetWorkflowmasterByCode(string code)
        {

            DeleteWorkflowmastercode(code);

           // var items = _DbWorkflowmasterContext.WorkflowmasterTable.Where(item => item.workflowmaster_refgroup == code);
                        
           // if (items.Any())
          //  {
          //      return items.ToList();
         //   }
            return null;
        }
        public Workflowmaster UpdateWorkflowmaster(Workflowmaster obj)
        {
            var items = _DbWorkflowmasterContext.WorkflowmasterTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Workflowmaster = items.FirstOrDefault();

           
            Workflowmaster.workflowmaster_createdate = obj.workflowmaster_createdate;
            Workflowmaster.workflowmaster_txdesc = obj.workflowmaster_txdesc;
            Workflowmaster.workflowmaster_group = obj.workflowmaster_group;
            Workflowmaster.workflowmaster_refgroup = obj.workflowmaster_refgroup;
            Workflowmaster.workflowmaster_refdim1 = obj.workflowmaster_refdim1;
            Workflowmaster.workflowmaster_refdim2 = obj.workflowmaster_refdim2;
            Workflowmaster.workflowmaster_active = obj.workflowmaster_active;
            Workflowmaster.workflowmaster_process = !Workflowmaster.workflowmaster_process;

            _DbWorkflowmasterContext.SaveChanges();
            return Workflowmaster;
        }
    }
}
