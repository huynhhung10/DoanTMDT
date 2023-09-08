using DoanTMDT.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoanTMDT.Client.Services.BrandService
{
    public interface IBrandService
    {
        event Action OnChange;
        List<Brand> Brands { get; set; }
        List<Brand> AdminBrands { get; set; }
        Task GetBrands();
        Task GetAdminBrands();
        Task AddBrand(Brand brand);
        Task UpdateBrand(Brand brand);
        Task DeleteBrand(int brandId);
        Brand CreateNewBrand();
    }
}
