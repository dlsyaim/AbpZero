using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.ProductApp.Dto
{
    public class ProductOutput : IOutputDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public int Type { get; set; }
    }

    public class GetCategoriesOutput : IOutputDto
    {
        public List<ProductOutput> Items { get; set; }
    }
}
