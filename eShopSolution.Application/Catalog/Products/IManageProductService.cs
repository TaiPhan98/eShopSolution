using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos.Manage;
using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{    // interface cho admin
    public interface IManageProductService
    {   // định nghĩa các phương thức
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequets request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int prodductId);

        Task<int> Delete(int productId);

        Task<List<ProductViewModel>> Getall();
        Task<PagedViewModel<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
