using CMS1.DTOs.NeoFolderModule;
using CMS1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS1.Services.NeoFolderModule
{
    public class NeoFolderService : INeoFolderService
    {
        private readonly ApplicationDbContext context;

        public NeoFolderService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<NeoFolderDTO>> GetAll()
        {
            try
            {
                var folder = await context.NeoFolders.ToListAsync();

                var folders = new List<NeoFolderDTO>();

                foreach (var item in folder)
                {
                    var data = new NeoFolderDTO
                    {
                        FolderId = item.FolderId,

                        FolderTreeId = item.FolderTreeId,

                        FolderPlacement = item.FolderPlacement,

                        Cid = item.Cid,

                        Uid = item.Uid,

                        Name = item.Name,

                        Sort = item.Sort,

                        Dtcreated = item.Dtcreated,

                        Dtmodified = item.Dtmodified,

                        Active = item.Active,

                    };

                    folders.Add(data);
                }

                return folders;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public async Task<NeoFolderDTO> GetFolderById(int Id)
        {
            try
            {
                var folder = await context.NeoFolders.FindAsync(Id);

                return new NeoFolderDTO
                {
                    FolderId = folder.FolderId,

                    FolderTreeId = folder.FolderTreeId,

                    FolderPlacement = folder.FolderPlacement,

                    Cid = folder.Cid,

                    Uid = folder.Uid,

                    Name = folder.Name,

                    Sort = folder.Sort,

                    Dtcreated = folder.Dtcreated,

                    Dtmodified = folder.Dtmodified,

                    Active = folder.Active,
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
    }
}
