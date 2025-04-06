using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils.Types;
using Kingmaker.EntitySystem.Stats;

namespace KineticPerformer
{
    class Archetype
    {
        public static void Configure()
        {
            ArchetypeConfigurator.New(name: "KineticPerformer", guid: Guids.Archetype, clazz: CharacterClassRefs.KineticistClass)
            .SetLocalizedName("KineticPerformer_Name")
            .SetLocalizedDescription("KineticPerformer_Desc")
            .SetReplaceSpellbook(Guids.SpellBook)
            .SetAddFeatures(LevelEntryBuilder.New()
                            .AddEntry(1, [Guids.KineticPerformerBurnFeature,
                                          Guids.KineticPerformanceDesctriptorFeature,
                                          ProgressionRefs.MentalOverflowProgression.ToString()])
                            .AddEntry(4, [FeatureRefs.SkilledKineticistFeature.ToString()])
                            .AddEntry(6, [FeatureRefs.BrewPotions.ToString()]))
            .SetRemoveFeatures(LevelEntryBuilder.New().
                                AddEntry(1, [FeatureRefs.BurnFeature.ToString(),
                                             ProgressionRefs.ElementalOverflowProgression.ToString()]))
            .SetReplaceClassSkills(true)
            .SetClassSkills([StatType.SkillKnowledgeArcana,
                             StatType.SkillKnowledgeWorld,
                             StatType.SkillThievery,
                             StatType.SkillMobility,
                             StatType.SkillPersuasion,
                             StatType.SkillStealth,
                             StatType.SkillUseMagicDevice,
                             StatType.SkillPerception])
            .SetChangeCasterType(true)
            .SetIsDivineCaster(false)
            .SetIsArcaneCaster(true)
            .SetAddSkillPoints(4)
            .SetOverrideAttributeRecommendations(true)
            .SetRecommendedAttributes([StatType.Dexterity,
                                       StatType.Charisma])
            .SetBaseAttackBonus("4c936de4249b61e419a3fb775b9f2581")
            .SetFortitudeSave("ff4662bde9e75f145853417313842751")
            .SetReflexSave("ff4662bde9e75f145853417313842751")
            .SetWillSave("dc0c7c1aba755c54f96c089cdf7d14a3")
            .SetDifficulty(1)
            .SetBuildChanging(true)
            .Configure();


            FeatureConfigurator.For(FeatureRefs.SkilledKineticistFeature)
            .AddPrerequisiteNoArchetype(archetype: Guids.Archetype, characterClass: CharacterClassRefs.KineticistClass.ToString())
            .Configure();

            FeatureConfigurator.For(FeatureRefs.BrewPotions)
            .AddPrerequisiteNoArchetype(archetype: Guids.Archetype, characterClass: CharacterClassRefs.KineticistClass.ToString())
            .Configure();

        }

    }

}