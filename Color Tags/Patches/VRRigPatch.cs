using HarmonyLib;
using UnityEngine;

namespace Color_Tags.Patches
{
    [HarmonyPatch(typeof(GorillaLocomotion.Player), "Awake")]
    public class VRRigPatch
    {
        public static void Postfix()
        {
            Debug.Log("Example Patch"); //this is so that the template includes the folder, don't actually need this
        }
    }
}