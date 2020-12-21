using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Saho.SchoolManagementSystem.Localization
{
    public static class SchoolManagementSystemLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SchoolManagementSystemConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SchoolManagementSystemLocalizationConfigurer).GetAssembly(),
                        "Saho.SchoolManagementSystem.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
