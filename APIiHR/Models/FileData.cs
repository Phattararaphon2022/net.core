using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class FileData
    {
        public int recid { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string MimeType { get; set; }
        public string FilePath { get; set; }
        public string Worker_code { get; set; }
        public string Module_form { get; set; }
        public string Name_fileupload { get; set; }
    }
}
