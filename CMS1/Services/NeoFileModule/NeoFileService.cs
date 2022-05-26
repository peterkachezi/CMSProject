using CMS1.DTOs.NeoFileModule;
using CMS1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS1.Services.NeoFileModule
{
    public class NeoFileService : INeoFileService
    {
        private readonly ApplicationDbContext context;
        public NeoFileService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<NeoFileDTO>> GetAll()
        {
            try
            {
                var folders = (from neofile in context.NeoFiles

                               join neofolder in context.NeoFolders on neofile.FolderId equals neofolder.FolderId

                               select new NeoFileDTO
                               {
                                   FileId = neofile.FileId,

                                   FolderId = neofile.FolderId,

                                   FolderName = neofolder.Name,

                                   Cid = neofile.Cid,

                                   Uid = neofile.Uid,

                                   Filename = neofile.Filename,

                                   FileType = neofile.FileType,

                                   Dtcreated = neofile.Dtcreated,

                                   Dtmodified = neofile.Dtmodified,

                                   Active = neofile.Active,

                                   FileData = neofile.FileData,

                                   FileHistoryId = neofile.FileHistoryId,

                                   Cur = neofile.Cur,

                               }).ToListAsync();

                return await folders;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public async Task<NeoFileDTO> GetNeoFileById(int Id)
        {
            try
            {
                var folders = (from neofile in context.NeoFiles

                               join neofolder in context.NeoFolders on neofile.FolderId equals neofolder.FolderId

                               where neofile.FolderId == Id

                               select new NeoFileDTO
                               {
                                   FileId = neofile.FileId,

                                   FolderId = neofile.FolderId,

                                   FolderName = neofolder.Name,

                                   Cid = neofile.Cid,

                                   Uid = neofile.Uid,

                                   Filename = neofile.Filename,

                                   FileType = neofile.FileType,

                                   Dtcreated = neofile.Dtcreated,

                                   Dtmodified = neofile.Dtmodified,

                                   Active = neofile.Active,

                                   FileData = neofile.FileData,

                                   FileHistoryId = neofile.FileHistoryId,

                                   Cur = neofile.Cur,

                               }).FirstOrDefaultAsync();

                return await folders;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }


    }
}
