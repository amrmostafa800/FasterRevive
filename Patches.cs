using HarmonyLib;

namespace FasterRevive
{
    public class MuckPatch
    {
        //[HarmonyPrefix, HarmonyPatch(typeof(GraveInteract), "set_timeLeft")]
        //public static bool set_timeLeft(float value)
        //{
        //    return false;
        //}

        [HarmonyPrefix, HarmonyPatch(typeof(GraveInteract), nameof(GraveInteract.SetTime))]
        public static bool SetTime(ref float time)
        {
            time = 10f;
            return true;
        }
    }
}
