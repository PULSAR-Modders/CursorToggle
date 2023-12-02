using HarmonyLib;

namespace Cursor_Toggle
{
    [HarmonyPatch(typeof(PLGameStatic), "Update")]
    internal class GameStatic
    {
        static void Postfix()
        {
            if (PLInput.Instance?.GetButtonDown(PLInputBase.EInputActionName.unlock_mouse) == true)
            {
                Input.mouseToggle = !Input.mouseToggle;
            }
        }
    }
}
