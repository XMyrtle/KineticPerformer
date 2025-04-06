using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Blueprints.References;
using Kingmaker.EntitySystem.Stats;

namespace KineticPerformer
{
    class KinecticPerformerBurnResource
    {
        public static void Configure()
        {
            AbilityResourceConfigurator.New(name: "KinecticPerformerBurnResource", guid: Guids.KinecticPerformerBurnResource)
            .SetMaxAmount(ResourceAmountBuilder.New(3)
                          .IncreaseByStat(StatType.Charisma))
            .Configure();
        }


    }

}