using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS1.DTOs.NeoFileAssociationModule
{
    public class NeoFileAssociationDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? TypeId { get; set; }
        public DateTime Dtcreated { get; set; }
        public DateTime? Dtmodified { get; set; }
        public bool Active { get; set; }
    }
}
