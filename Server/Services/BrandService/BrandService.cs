using DoanTMDT.Server.Data;
using DoanTMDT.Server.Services.ProductService;
using DoanTMDT.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DoanTMDT.Server.Services.BrandService
{
    public class BrandService : IBrandService
    {
        private readonly DataContext _context;

        public BrandService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Brand>>> AddBrand(Brand brand)
        {
            brand.Editing = brand.IsNew = false;
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();
            return await GetAdminBrands();
        }

        public async Task<ServiceResponse<List<Brand>>> DeleteBrand(int id)
        {
            Brand brand = await GetBrandById(id);
            if (brand == null)
            {
                return new ServiceResponse<List<Brand>>
                {
                    Success = false,
                    Message = "Brand not found."
                };
            }

            brand.Deleted = true;
            await _context.SaveChangesAsync();

            return await GetAdminBrands();
        }

        private async Task<Brand> GetBrandById(int id)
        {
            return await _context.Brands.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<ServiceResponse<List<Brand>>> GetAdminBrands()
        {
            var brands = await _context.Brands
                .Where(c => !c.Deleted)
                .ToListAsync();
            return new ServiceResponse<List<Brand>>
            {
                Data = brands
            };
        }

        public async Task<ServiceResponse<List<Brand>>> GetBrands()
        {
            var brands = await _context.Brands
                .Where(c => !c.Deleted && c.Visible)
                .ToListAsync();
            return new ServiceResponse<List<Brand>>
            {
                Data = brands
            };
        }

        public async Task<ServiceResponse<List<Brand>>> UpdateBrand(Brand brand)
        {
            var dbBrand = await GetBrandById(brand.Id);
            if (dbBrand == null)
            {
                return new ServiceResponse<List<Brand>>
                {
                    Success = false,
                    Message = "Brand not found."
                };
            }

            dbBrand.BrandName = brand.BrandName;
            dbBrand.BrandUrl = brand.BrandUrl;
            dbBrand.Icon = brand.Icon;
            dbBrand.Visible = brand.Visible;

            await _context.SaveChangesAsync();

            return await GetAdminBrands();

        }
    }
}
