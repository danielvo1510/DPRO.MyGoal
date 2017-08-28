using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DPRO.Mygoal.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace DPRO.Mygoal.Web.Host.Startup
{
    [DependsOn(
       typeof(MygoalWebCoreModule))]
    public class MygoalWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MygoalWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MygoalWebHostModule).GetAssembly());
        }
    }
}
