using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using Kingmaker.EntitySystem.Stats;


namespace KineticPerformer
{
    class KineticPerformerBurnFeature
    {
        public static void Configure()
        {
            FeatureConfigurator.New(name: "KineticPerformerBurnFeature", guid: Guids.KineticPerformerBurnFeature)
            .AddAbilityResources(resource: Guids.KinecticPerformerBurnResource,
                                 amount: 0)
            .AddKineticistPart(clazz: CharacterClassRefs.KineticistClass.ToString(),
                                mainStat: StatType.Charisma,
                                maxBurn: Guids.KinecticPerformerBurnResource,
                                maxBurnPerRound: AbilityResourceRefs.BurnPerRoundResource.ToString(),
                                gatherPowerAbility: FeatureRefs.GatherPowerFeature.ToString(),
                                gatherPowerBuff1: BuffRefs.GatherPowerBuffI.ToString(),
                                gatherPowerBuff2: BuffRefs.GatherPowerBuffII.ToString(),
                                gatherPowerBuff3: BuffRefs.GatherPowerBuffIII.ToString(),
                                blasts: [AbilityRefs.AirBlastBase.ToString(),
                                         AbilityRefs.BlizzardBlastBase.ToString(),
                                         AbilityRefs.BlueFlameBlastBase.ToString(),
                                         AbilityRefs.ChargedWaterBlastBase.ToString(),
                                         AbilityRefs.ColdBlastBase.ToString(),
                                         AbilityRefs.EarthBlastBase.ToString(),
                                         AbilityRefs.ElectricBlastBase.ToString(),
                                         AbilityRefs.FireBlastBase.ToString(),
                                         AbilityRefs.IceBlastBase.ToString(),
                                         AbilityRefs.MagmaBlastBase.ToString(),
                                         AbilityRefs.MetalBlastBase.ToString(),
                                         AbilityRefs.MudBlastBase.ToString(),
                                         AbilityRefs.PlasmaBlastBase.ToString(),
                                         AbilityRefs.SandstormBlastBase.ToString(),
                                         AbilityRefs.SteamBlastBase.ToString(),
                                         AbilityRefs.ThunderstormBlastBase.ToString(),
                                         AbilityRefs.WaterBlastBase.ToString()],
                                bladeActivatedBuff: BuffRefs.KineticBladeEnableBuff.ToString(),
                                canGatherPowerWithShieldBuff: null)
            .AddAbilityResources(resource: AbilityResourceRefs.BurnPerRoundResource.ToString())
            .AddKineticistBurnValueChangedTrigger(action: ActionsBuilder.New()
                                                        .ApplyBuffPermanent(buff: Guids.KinecticPerformerBurnBuff))
            .SetDisplayName("KineticPerformerBurnFeature_Name")
            .SetDescription("KineticPerformerBurnFeature_Desc")
            .Configure();

        }

    }

}