using DoanTMDT.Server.Data;
using DoanTMDT.Server.Services.ProductService;
using DoanTMDT.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DoanTMDT.Server.Services.EditionService
{
    public class EditionService : IEditionService
    {
        private readonly DataContext _context;

        public EditionService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Edition>>> AddEdition(Edition edition)
        {
            edition.Editing = edition.IsNew = false;
            _context.Editions.Add(edition);
            await _context.SaveChangesAsync();

            return await GetEditions();
        }

        public async Task<ServiceResponse<List<Edition>>> GetEditions()
        {
            var editions = await _context.Editions.ToListAsync();
            return new ServiceResponse<List<Edition>> { Data = editions };
        }

        public async Task<ServiceResponse<List<Edition>>> UpdateEdition(Edition productType)
        {
            var dbProductType = await _context.Editions.FindAsync(productType.Id);
            if (dbProductType == null)
            {
                return new ServiceResponse<List<Edition>>
                {
                    Success = false,
                    Message = "Product Type not found."
                };
            }

            dbProductType.Name = productType.Name;
            await _context.SaveChangesAsync();

            return await GetEditions();
        }
    }
}
