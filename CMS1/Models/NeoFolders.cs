using System;
using System.Collections.Generic;

namespace CMS1.Models
{
    public partial class NeoFolders
    {
        public int FolderId { get; set; }
        public string FolderTreeId { get; set; }
        public int FolderPlacement { get; set; }
        public int Cid { get; set; }
        public int Uid { get; set; }
        public string Name { get; set; }
        public int? Sort { get; set; }
        public DateTime Dtcreated { get; set; }
        public DateTime? Dtmodified { get; set; }
        public bool? Active { get; set; }
    }
}
