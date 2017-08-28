using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using DPRO.Mygoal.Authorization.Users;
using DPRO.Mygoal.Editions;

namespace DPRO.Mygoal.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}