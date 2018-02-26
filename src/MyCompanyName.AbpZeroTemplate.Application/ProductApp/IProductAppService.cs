using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompanyName.AbpZeroTemplate.ProductApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.ProductApp
{
    public interface IProductAppService : IApplicationService
    {

        Task<PagedResultDto<ProductOutput>> GetProducts();
    }
}
