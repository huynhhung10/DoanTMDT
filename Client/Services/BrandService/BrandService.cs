using DoanTMDT.Client.Services.BrandService;
using DoanTMDT.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DoanTMDT.Client.Services.BrandService
{
    public class BrandService : IBrandService
    {
        private readonly HttpClient _http;

        public BrandService(HttpClient http)
        {
            _http = http;
        }

        public List<Brand> Brands { get; set; } = new List<Brand>();
        public List<Brand> AdminBrands { get; set; } = new List<Brand>();

        public event Action OnChange;

        public async Task AddBrand(Brand brand)
        {
            var response = await _http.PostAsJsonAsync("api/brand/admin", brand);
            AdminBrands = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Brand>>>()).Data;
            await GetBrands();
            OnChange.Invoke();
        }

        public Brand CreateNewBrand()
        {
            var newBrand = new Brand { IsNew = true, Editing = true };
            AdminBrands.Add(newBrand);
            OnChange.Invoke();
            return newBrand;
        }

        public async Task DeleteBrand(int brandId)
        {
            var response = await _http.DeleteAsync($"api/brand/admin/{brandId}");
            AdminBrands = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Brand>>>()).Data;
            await GetBrands();
            OnChange.Invoke();
        }

        public async Task GetAdminBrands()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Brand>>>("api/brand/admin");
            if (response != null && response.Data != null)
                AdminBrands = response.Data;
        }

        public async Task GetBrands()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Brand>>>("api/brand");
            if (response != null && response.Data != null)
                Brands = response.Data;
        }

        public async Task UpdateBrand(Brand brand)
        {
            var response = await _http.PutAsJsonAsync("api/brand/admin", brand);
            AdminBrands = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Brand>>>()).Data;
            await GetBrands();
            OnChange.Invoke();
        }
    }
}
