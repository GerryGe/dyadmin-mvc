using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace Dychar.Dyadmin.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}
