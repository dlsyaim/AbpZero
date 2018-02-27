using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using AutoMapper;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Configuration;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Abp.Notifications;
using Abp.Runtime.Session;
using Abp.UI;
using Abp.Zero.Configuration;
using Microsoft.AspNet.Identity;
using MyCompanyName.AbpZeroTemplate.Authorization.Users.Dto;
using MyCompanyName.AbpZeroTemplate.Entities;
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

        public async Task<PagedResultDto<ProductOutput>> GetProductListAsync(GetProductsInput input)
        {
            try
            {
                var query = _productRepository.GetAll()
                .WhereIf(!string.IsNullOrWhiteSpace(input.Name), p => p.Name.Contains(input.Name));

                var items = Mapper.Map<List<ProductOutput>>(query);
                var count = await query.CountAsync();
                return new PagedResultDto<ProductOutput>(count, items.ToList());






            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public  Task<PagedResultDto<ProductOutput>> GetProducts()
        //{
        //    //throw new NotImplementedException();
        //    //创建映射
        //    //Mapper.CreateMap<Product, ProductOutput>();
        //    var result = _productRepository.GetAllList();
        //    int totalCount = result.Count;
        //    //return new PagedResultDto<ProductOutput>(
        //    //    totalCount,
        //    //    Mapper.Map<List<ProductOutput>>(result)
        //    //    );


        //    //return new PagedResultDto<ProductOutput>(
        //    //    totalCount,
        //    //      Mapper.Map<List<ProductOutput>>(result)
        //    //    );


        //}
        //public Task<PagedResultDto<ProductOutput>> GetProducts()
        //{

        //}
    }
}
