using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompanyName.AbpZeroTemplate.Authorization.Users.Dto;
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

       // Task<PagedResultDto<ProductOutput>> GetProducts();

        /// <summary>
        /// 根据查询条件获取仪表分页列表
        /// </summary>
        Task<PagedResultDto<ProductOutput>> GetProductListAsync(GetProductsInput input);
        Task<PagedResultDto<ProductOutput>> GetProductListAsync();

        ///// <summary>
        ///// 获取指定id的仪表信息
        ///// </summary>
        //Task<MeterDto> GetMeter(IdInput input);

        ///// <summary>
        ///// 新增或更改仪表
        ///// </summary>
        //Task CreateOrUpdateMeter(MeterDto input);

        ///// <summary>
        ///// 新增仪表
        ///// </summary>
        //Task<MeterDto> CreateMeter(MeterDto input);

        ///// <summary>
        ///// 更新仪表
        ///// </summary>
        //Task UpdateMeter(MeterDto input);

        ///// <summary>
        ///// 删除仪表
        ///// </summary>
        //Task DeleteMeter(IdInput input);

        ///// <summary>
        ///// 导出到表格
        ///// </summary>
        ///// <returns></returns>
        //Task<FileDto> GetMetersToExcel();
    }
}
