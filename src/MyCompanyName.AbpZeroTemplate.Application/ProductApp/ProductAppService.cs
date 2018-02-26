using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AutoMapper;
using MyCompanyName.AbpZeroTemplate.IRepositories;
using MyCompanyName.AbpZeroTemplate.ProductApp.Dto;

namespace MyCompanyName.AbpZeroTemplate.ProductApp
{
    public class ProductAppService : AbpZeroTemplateAppServiceBase, IProductAppService
    {
        private readonly IProductRepository _productRepository;
        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<PagedResultDto<ProductOutput>> GetProducts()
        {
            //创建映射
            Mapper.CreateMap<Product, ProductOutput>();
            var result = _productRepository.GetAllList();
            int totalCount = result.Count;
            return new PagedResultOutput<ProductOutput>(
                totalCount,
                Mapper.Map<List<ProductOutput>>(result)
                );
        }
    }
    }
}
