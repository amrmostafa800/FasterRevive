using BepInEx;
using HarmonyLib;

namespace FasterRevive
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class FasterRevive : BaseUnityPlugin
    {
        public const string
            GUID = "FasterRevive",
            NAME = "FasterRevive",
            VERSION = "1.0.0";

        public void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(MuckPatch));
            Logger.LogMessage("Loaded FasterRevive");
        }
    }
}
