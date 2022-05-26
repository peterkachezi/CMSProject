using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS1.DTOs.NeoFileModule
{
    public class NeoFileDTO
    {
        public int FileId { get; set; }
        public int FolderId { get; set; }
        public string FolderName { get; set; }
        public int Cid { get; set; }
        public int Uid { get; set; }
        public string Filename { get; set; }
        public string FileType { get; set; }
        public byte[] FileData { get; set; }
        public string FileHistoryId { get; set; }
        public DateTime Dtcreated { get; set; }
        public DateTime? Dtmodified { get; set; }
        public bool? Cur { get; set; }
        public bool? Active { get; set; }
    }
}
