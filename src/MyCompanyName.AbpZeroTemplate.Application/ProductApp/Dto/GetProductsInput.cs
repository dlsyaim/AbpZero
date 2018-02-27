using Abp.Runtime.Validation;
using MyCompanyName.AbpZeroTemplate.Dto;

namespace MyCompanyName.AbpZeroTemplate.Authorization.Users.Dto
{
    public class GetProductsInput : PagedAndSortedInputDto, IShouldNormalize
    {
        //public string Filter { get; set; }

        //public string Permission { get; set; }

        //public int? Role { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public int Type { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Name,Code";
            }
        }
    }
}