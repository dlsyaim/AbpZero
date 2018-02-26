using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Entities
{
    public class Product:Entity
    {
        //供应商名称，供应商编号，地址，电话，供应商类型,等等
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public int Type { get; set; }

    }
}
