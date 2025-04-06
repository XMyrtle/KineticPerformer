using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BlueprintCore.Utils;
using HarmonyLib;
using Kingmaker.Blueprints.JsonSystem;
using UnityModManagerNet;

namespace KineticPerformer
{
#if DEBUG
    [EnableReloading]
#endif
    public static class Main
    {
        internal static Harmony HarmonyInstance;
        internal static UnityModManager.ModEntry.ModLogger log;
        private static readonly LogWrapper Logger = LogWrapper.Get("GeoEnchanter");

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            log = modEntry.Logger;
#if DEBUG
            modEntry.OnUnload = OnUnload;
#endif
            modEntry.OnGUI = OnGUI;
            HarmonyInstance = new Harmony(modEntry.Info.Id);
            HarmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
            return true;
        }

        public static void OnGUI(UnityModManager.ModEntry modEntry)
        {

        }

#if DEBUG
        public static bool OnUnload(UnityModManager.ModEntry modEntry)
        {
            HarmonyInstance.UnpatchAll(modEntry.Info.Id);
            return true;
        }
#endif
        [HarmonyPatch(typeof(BlueprintsCache))]
        public static class BlueprintsCaches_Patch
        {
            private static bool Initialized = false;

            [HarmonyPriority(Priority.First)]
            [HarmonyPatch(nameof(BlueprintsCache.Init)), HarmonyPostfix]
            public static void Init_Postfix()
            {
                try
                {
                    if (Initialized)
                    {
                        log.Log("Already initialized blueprints cache.");
                        return;
                    }
                    Initialized = true;

                    Logger.Info("Patching blueprints Kinetic Performer.");
                    Archetype.Configure();
                    Logger.Info("Patching blueprints KinecticPerformerBurnBuff.");
                    KinecticPerformerBurnBuff.Configure();
                    Logger.Info("Patching blueprints KineticPerformanceDesctriptorFeature.");
                    KineticPerformanceDesctriptorFeature.Configure();
                    Logger.Info("Patching blueprints KinecticPerformerBurnResource.");
                    KinecticPerformerBurnResource.Configure();
                    Logger.Info("Patching blueprints KineticPerformerBurnFeature.");
                    KineticPerformerBurnFeature.Configure();
                    Logger.Info("Patching blueprints SpellBook.");
                    SpellBook.Configure();


                }
                catch (Exception e)
                {
                    Logger.Error("Failed to initialize Kinetic Performer.", e);
                }
            }
        }
    }
}
