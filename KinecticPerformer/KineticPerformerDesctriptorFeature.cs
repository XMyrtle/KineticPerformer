using BlueprintCore.Blueprints.CustomConfigurators.Classes;

namespace KineticPerformer
{
    class KineticPerformanceDesctriptorFeature
    {
        public static void Configure()
        {
            FeatureConfigurator.New(name: "KineticPerformanceDesctriptorFeature", guid: Guids.KineticPerformanceDesctriptorFeature)
            .SetDisplayName("KineticPerformanceDesctriptorFeature_Name")
            .SetDescription("KineticPerformanceDesctriptorFeature_Desc")
            .Configure();
        }

    }

}