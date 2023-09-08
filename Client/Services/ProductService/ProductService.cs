using DoanTMDT.Client.Services.ProductService;
using DoanTMDT.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DoanTMDT.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public string Message { get; set; } = "Loading products...";
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 0;
        public string LastSearchText { get; set; } = string.Empty;
        public string LastAdminSearchText { get; set; } = string.Empty;
        public string categoryurl { get; set; } = string.Empty;
        public string brandurl { get; set; } = string.Empty;
        public List<Product> AdminProducts { get; set; }

        public event Action ProductsChanged;

        

        public async Task GetProducts(string categoryUrl )
        {
           
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/Category/{categoryUrl}");
            if (result != null && result.Data != null)
                Products = result.Data; 
            CurrentPage = 1;
            PageCount = 0;
            if(Products.Count == 0)
            {
                Message = "No products found.";
            }
        
            ProductsChanged.Invoke();
        }

        public async Task GetProductss(string brandUrl = null)
        {
            var result = brandUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/Brand/{brandUrl}");
            if (result != null && result.Data != null)
                Products = result.Data;
            CurrentPage = 1;
            PageCount = 0;
            if (Products.Count == 0)
            {
                Message = "No products found.";
            }

            ProductsChanged.Invoke();
        }

        public async Task<List<string>> GetProductSearchSuggestions(string searchText)
        {
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchsuggestions/{searchText}");
            return result.Data;
        }

       public async Task SearchProducts(string searchText, int page)
        {
            LastSearchText = searchText;
            var result = await _http
                 .GetFromJsonAsync<ServiceResponse<ProductSearchResult>>($"api/product/search/{searchText}/{page}");
            if (result != null && result.Data != null)
            {
                Products = result.Data.Products;
                CurrentPage = result.Data.CurrentPage;
                PageCount = result.Data.Pages;
            }
            if (Products.Count == 0) Message = "No products found.";
            ProductsChanged.Invoke();
        }

        public async Task PagesCategory(string categoryUrl, int page)
        {
            categoryurl = categoryUrl;
            var result = await _http
                 .GetFromJsonAsync<ServiceResponse<ProductSearchResult>>($"api/product/category/{categoryUrl}/{page}");
            if (result != null && result.Data != null)
            {
                Products = result.Data.Products;
                CurrentPage = result.Data.CurrentPage;
                PageCount = result.Data.Pages;
            }
            if (Products.Count == 0) Message = "No products found.";
            ProductsChanged.Invoke();
        }

        public async Task PagesBrand(string brandUrl, int page)
        {
            brandurl = brandUrl;
            var result = await _http
                 .GetFromJsonAsync<ServiceResponse<ProductSearchResult>>($"api/product/brand/{brandUrl}/{page}");
            if (result != null && result.Data != null)
            {
                Products = result.Data.Products;
                CurrentPage = result.Data.CurrentPage;
                PageCount = result.Data.Pages;
            }
            if (Products.Count == 0) Message = "No products found.";
            ProductsChanged.Invoke();
        }

        

        public async Task GetAllProducts()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
                if (response != null && response.Data != null)
                Products = response.Data;

        }

        /* ------------------------Admin------------------------------------*/

        public async Task<Product> CreateProduct(Product product)
        {
            var result = await _http.PostAsJsonAsync("api/product", product);
            var newProduct = (await result.Content.ReadFromJsonAsync<ServiceResponse<Product>>()).Data;
            return newProduct;
        }

        public async Task DeleteProduct(Product product)
        {
            var result = await _http.DeleteAsync($"api/product/{product.Id}");
        }

        public async Task GetAdminProducts()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product/admin");
            AdminProducts = result.Data;
            CurrentPage = 1;
            PageCount = 0;
            if (AdminProducts.Count == 0)
                Message = "No products found.";
        }

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }
        public async Task<Product> UpdateProduct(Product product)
        {
            var result = await _http.PutAsJsonAsync($"api/product", product);
            var content = await result.Content.ReadFromJsonAsync<ServiceResponse<Product>>();
            return content.Data;
        }

        public async Task<List<string>> GetAdminProductSearchSuggestions(string searchText)
        {
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/admin/searchsuggestions/{searchText}");
            return result.Data;
        }

        public async Task SearchAdminProducts(string searchText, int page)
        {
            LastAdminSearchText = searchText;
            var result = await _http
                 .GetFromJsonAsync<ServiceResponse<ProductSearchResult>>($"api/product/admin/search/{searchText}/{page}");
            if (result != null && result.Data != null)
            {
                Products = result.Data.Products;
                CurrentPage = result.Data.CurrentPage;
                PageCount = result.Data.Pages;
            }
            if (Products.Count == 0) Message = "No products found.";
            ProductsChanged.Invoke();
        }
    }
}
