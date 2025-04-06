

using BlueprintCore.Blueprints.Configurators.Classes;
using BlueprintCore.Blueprints.Configurators.Classes.Spells;
using BlueprintCore.Blueprints.CustomConfigurators.Classes.Spells;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Utility;

namespace KineticPerformer
{


    class SpellBook
    {
        public static void Configure()
        {
            SpellsTableConfigurator.New(name: "KineticPerformerSpellLevels", Guids.SpellLevels)
           .SetLevels(GetSpellLevels())
           .Configure();

            SpellListConfigurator.New(name: "KineticPerformerSpellList", Guids.SpellList)
            .SetSpellsByLevel(GetSpellList())
            .Configure();

            SpellbookConfigurator.New(name: "KineticPerformerSpellBook", guid: Guids.SpellBook)
            .SetSpellsPerDay(Guids.SpellLevels)
            .SetSpellsKnown(SpellsTableRefs.BardSpellsKnownTable.ToString())
            .SetSpellList(Guids.SpellList)
            .SetCharacterClass(CharacterClassRefs.KineticistClass.ToString())
            .SetCastingAttribute(StatType.Charisma)
            .SetSpontaneous(true)
            .SetSpellsPerLevel(0)
            .SetAllSpellsKnown(false)
            .SetCantripsType(CantripsType.Cantrips)
            .SetName("SpellBook_Name")
            .Configure();

            FeatureSelectMythicSpellbookConfigurator.For(FeatureSelectMythicSpellbookRefs.AngelIncorporateSpellbook.ToString())
            .AddToAllowedSpellbooks(Guids.SpellBook)
            .Configure();
            FeatureSelectMythicSpellbookConfigurator.For(FeatureSelectMythicSpellbookRefs.LichIncorporateSpellbookFeature.ToString())
            .AddToAllowedSpellbooks(Guids.SpellBook)
            .Configure();
        }

        private static SpellsLevelEntry[] GetSpellLevels()
        {
            return [/*00*/new SpellsLevelEntry{ Count= []},
                    /*01*/new SpellsLevelEntry{ Count= [0, 1]},
                    /*02*/new SpellsLevelEntry{ Count= [0, 2]},
                    /*03*/new SpellsLevelEntry{ Count= [0, 3]},
                    /*04*/new SpellsLevelEntry{ Count= [0, 3, 1]},
                    /*05*/new SpellsLevelEntry{ Count= [0, 4, 2]},
                    /*06*/new SpellsLevelEntry{ Count= [0, 4, 3]},
                    /*07*/new SpellsLevelEntry{ Count= [0, 4, 3, 1]},
                    /*08*/new SpellsLevelEntry{ Count= [0, 4, 4, 2]},
                    /*09*/new SpellsLevelEntry{ Count= [0, 5, 4, 3]},
                    /*10*/new SpellsLevelEntry{ Count= [0, 5, 4, 3, 1]},
                    /*11*/new SpellsLevelEntry{ Count= [0, 5, 4, 4, 2]},
                    /*12*/new SpellsLevelEntry{ Count= [0, 5, 5, 4, 3]},
                    /*13*/new SpellsLevelEntry{ Count= [0, 5, 5, 4, 3, 1]},
                    /*14*/new SpellsLevelEntry{ Count= [0, 5, 5, 4, 4, 2]},
                    /*15*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 4, 3]},
                    /*16*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 4, 3, 1]},
                    /*17*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 4, 4, 2]},
                    /*18*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 4, 3]},
                    /*19*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 4]},
                    /*20*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5]},
                    /*21*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 1]},
                    /*22*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 2]},
                    /*23*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 3,]},
                    /*24*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 4, 1]},
                    /*25*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 2]},
                    /*26*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 3]},
                    /*27*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 4, 1]},
                    /*28*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 2]},
                    /*29*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 3]},
                    /*30*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 4]},
                    /*31*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 5]},
                    /*32*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 5]},
                    /*33*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 5]},
                    /*34*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 5]},
                    /*35*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 5]},
                    /*36*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 5]},
                    /*37*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 5]},
                    /*38*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 5]},
                    /*39*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 5]},
                    /*40*/new SpellsLevelEntry{ Count= [0, 5, 5, 5, 5, 5, 5, 5, 5, 5]}];
        }
        private static SpellLevelList[] GetSpellList()
        {
            var BardSpells = SpellListRefs.BardSpellList.Reference.Get();
            var ShamanSpells = SpellListRefs.ShamanSpelllist.Reference.Get();
            SpellLevelList[] SpellsByLevel = BardSpells.SpellsByLevel;
            SpellLevelList[] X = ShamanSpells.SpellsByLevel;

            SpellsByLevel.SetValue(X.GetValue(7), 7);
            SpellsByLevel.SetValue(X.GetValue(8), 8);
            SpellsByLevel.SetValue(X.GetValue(9), 9);
            return SpellsByLevel;
        }
    }
}