using PulsarPluginLoader.Chat.Commands.CommandRouter;
using PulsarPluginLoader.Utilities;

namespace BeamMeUp
{
    class Command : PublicCommand
    {
        public override string[] CommandAliases()
        {
            return new string[] { "beamMeUp" };
        }

        public override string Description()
        {
            return "Teleport the player back to the ship";
        }

        public override void Execute(string arguments, int SenderID)
        {
            if (PhotonNetwork.isMasterClient)
            {
                PLPlayer player = HelperMethods.GetPlayerFromPlayerID(SenderID);
                int hubID = PLEncounterManager.Instance.PlayerShip.MyTLI.SubHubID;
                player.photonView.RPC("NetworkTeleportToSubHub", PhotonTargets.All, new object[]
                {
                hubID,
                0
                });
            }
        }
    }
}
