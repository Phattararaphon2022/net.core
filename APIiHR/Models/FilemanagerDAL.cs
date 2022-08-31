using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class FilemanagerDAL
    {
        public int recid { get; set; }
        public DateTime filemanager_createdate { get; set; }
        public DateTime filemanager_modifydate { get; set; }
        public string filemanager_worker_code { get; set; }
        public string filemanager_filename { get; set; }
        public string filemanager_fileexten { get; set; }
        public string filemanager_filetype { get; set; }
        public string filemanager_filepath { get; set; }
        public int filemanager_status { get; set; }
        public Boolean filemanager_setsecu { get; set; }
        public string filemanager_setpass { get; set; }
        public string filemanager_txdesc { get; set; }
        public string filemanager_module { get; set; }
        public string filemanager_fileupload { get; set; }
    }
}
