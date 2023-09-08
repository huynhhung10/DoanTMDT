using DoanTMDT.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoanTMDT.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        List<Product> AdminProducts { get; set; }
        string Message { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }
        string LastAdminSearchText { get; set; }
        string categoryurl { get; set; }
        string brandurl { get; set; }
        Task GetAllProducts();

        Task GetProducts(string categoryUrl = null);
        Task GetProductss( string brandUrl = null);
        Task PagesCategory(string categoryUrl, int page);

        Task PagesBrand(string brandyUrl, int page);

        Task<ServiceResponse<Product>> GetProduct(int productId);

        Task SearchProducts(string searchText, int page);
        Task<List<string>> GetProductSearchSuggestions(string searchText);

        /* ------------------------Admin------------------------------------*/

        Task GetAdminProducts();
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task DeleteProduct(Product product);
        Task SearchAdminProducts(string searchText, int page);
        Task<List<string>> GetAdminProductSearchSuggestions(string searchText);
    }
}
