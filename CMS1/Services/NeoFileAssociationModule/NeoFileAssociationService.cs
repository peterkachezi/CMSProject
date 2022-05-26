using CMS1.DTOs.NeoFileAssociationModule;
using CMS1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS1.Services.NeoFileAssociationModule
{
    public class NeoFileAssociationService : INeoFileAssociationService
    {
        private readonly ApplicationDbContext context;
        public NeoFileAssociationService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<NeoFileAssociationDTO>> GetAll()
        {
            try
            {
                var neoAssociation = await context.NeoFileAssociations.ToListAsync();

                var neoAssociations = new List<NeoFileAssociationDTO>();

                foreach (var item in neoAssociation)
                {
                    var data = new NeoFileAssociationDTO
                    {
                        Type = item.Type,

                        TypeId = item.TypeId,

                        Dtcreated = item.Dtcreated,

                        Dtmodified = item.Dtmodified,

                        Active = item.Active,
                    };
                    neoAssociations.Add(data);
                }

                return neoAssociations;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public async Task<NeoFileAssociationDTO> GetById(int Id)
        {
            try
            {
                var neoAssociation = await context.NeoFileAssociations.FindAsync(Id);

                return new NeoFileAssociationDTO
                {
                    Type = neoAssociation.Type,

                    TypeId = neoAssociation.TypeId,

                    Dtcreated = neoAssociation.Dtcreated,

                    Dtmodified = neoAssociation.Dtmodified,

                    Active = neoAssociation.Active,
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
