using PulsarModLoader.CustomGUI;
using UnityEngine;

namespace Cursor_Toggle
{
    internal class GUI : ModSettingsMenu
    {
        public override void Draw()
        {
            Input.mouseToggleToggle = GUILayout.Toggle(Input.mouseToggleToggle, "Toggle mouse unlock");
            if (!Input.mouseToggleToggle)
            {
                Input.mouseToggle = false;
            }
        }

        public override string Name()
        {
            return Mod.Instance.Name;
        }
    }
}
