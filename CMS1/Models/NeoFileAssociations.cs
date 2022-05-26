using System;
using System.Collections.Generic;

namespace CMS1.Models
{
    public partial class NeoFileAssociations
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? TypeId { get; set; }
        public DateTime Dtcreated { get; set; }
        public DateTime? Dtmodified { get; set; }
        public bool Active { get; set; }
    }
}
