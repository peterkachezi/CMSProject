using CMS1.DTOs.NeoFolderModule;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS1.Services.NeoFolderModule
{
    public interface INeoFolderService
    {
        Task<List<NeoFolderDTO>> GetAll();
        Task<NeoFolderDTO> GetFolderById(int Id);
    }
}