using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dychar.Dyadmin.Configuration;

namespace Dychar.Dyadmin.Web.Host.Startup
{
    [DependsOn(
       typeof(DyadminWebCoreModule))]
    public class DyadminWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DyadminWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DyadminWebHostModule).GetAssembly());
        }
    }
}
