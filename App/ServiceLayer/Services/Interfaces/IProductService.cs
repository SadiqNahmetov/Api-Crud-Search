using DomainLayer.Entities;
using ServiceLayer.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IProductService
    {
        Task CreateAsync(ProductCreateDto product);
        Task<List<ProductListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, ProductUpdateDto product);

        Task<List<ProductListDto>> SearchAsync(string? searchText);
        Task<Product> GetById(int id);



    }
}
