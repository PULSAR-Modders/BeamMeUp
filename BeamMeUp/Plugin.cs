using PulsarPluginLoader;

namespace BeamMeUp
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "0.0.0";

        public override string Author => "18107";

        public override string ShortDescription => "Allows players to teleport back to the ship at any time";

        public override string Name => "Beam Me Up";

        public override string HarmonyIdentifier()
        {
            return "mod.id107.beammeup";
        }
    }
}
