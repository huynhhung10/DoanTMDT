using DoanTMDT.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoanTMDT.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        Task<ServiceResponse<List<Product>>> GetProductsByBrand(string brandUrl);

        Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page);
        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);

        Task<ServiceResponse<ProductSearchResult>> PagesCategory(string categoryUrl, int page);
        Task<ServiceResponse<ProductSearchResult>> PagesBrand(string brandUrl, int page);


        /* ------------------------Admin------------------------------------*/
        Task<ServiceResponse<List<Product>>> GetAdminProducts();
        Task<ServiceResponse<Product>> CreateProduct(Product product);
        Task<ServiceResponse<Product>> UpdateProduct(Product product);
        Task<ServiceResponse<bool>> DeleteProduct(int productId);
        Task<ServiceResponse<List<string>>> GetAdminProductSearchSuggestions(string searchText);
        Task<ServiceResponse<ProductSearchResult>> SearchAdminProducts(string searchText, int page);

    }
}
