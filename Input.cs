using HarmonyLib;
using System;

namespace Cursor_Toggle
{
    [HarmonyPatch(typeof(PLInput), "GetButton", new Type[] { typeof(PLInputBase.EInputActionName) })]
    internal class Input
    {
        public static bool mouseToggle = false;
        public static bool mouseToggleToggle = true;
        static void Postfix(PLInputBase.EInputActionName inActionName, ref bool __result)
        {
            if (mouseToggleToggle && inActionName == PLInputBase.EInputActionName.unlock_mouse)
            {
                __result = mouseToggle;
            }
        }
    }
}
