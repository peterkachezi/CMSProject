using CMS1.DTOs.NeoFileModule;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS1.Services.NeoFileModule
{
    public interface INeoFileService
    {
        Task<List<NeoFileDTO>> GetAll();
        Task<NeoFileDTO> GetNeoFileById(int Id);
    }
}