using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DPRO.Mygoal.Authorization;

namespace DPRO.Mygoal
{
    [DependsOn(
        typeof(MygoalCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MygoalApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MygoalAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(MygoalApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}