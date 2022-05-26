using CMS1.DTOs.NeoFileAssociationModule;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS1.Services.NeoFileAssociationModule
{
    public interface INeoFileAssociationService
    {
        Task<List<NeoFileAssociationDTO>> GetAll();
        Task<NeoFileAssociationDTO> GetById(int Id);
    }
}