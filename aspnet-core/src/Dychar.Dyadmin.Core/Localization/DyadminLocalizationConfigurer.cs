using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Dychar.Dyadmin.Localization
{
    public static class DyadminLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DyadminConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DyadminLocalizationConfigurer).GetAssembly(),
                        "Dychar.Dyadmin.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
