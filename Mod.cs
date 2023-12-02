using PulsarModLoader;

namespace Cursor_Toggle
{
    public class Mod : PulsarMod
    {
        public static Mod Instance { get; private set; }

        public Mod()
        {
            Instance = this;
        }

        public override string Version => "0.0.0";

        public override string Author => "18107";

        public override string ShortDescription => "Changes the mouse unlock from hold to toggle";

        public override string Name => "Cursor Toggle";

        public override string ModID => "cursortoggle";

        public override string HarmonyIdentifier()
        {
            return "id107.cursortoggle";
        }
    }
}
