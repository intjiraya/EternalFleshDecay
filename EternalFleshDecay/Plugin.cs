using Exiled.API.Features;
using Exiled.Events.Handlers;
using Exiled.Events.EventArgs.Scp3114;
using Exiled.API.Enums;
using System.Dynamic;
using InventorySystem.Items.Coin;
using Exiled.Events.EventArgs.Player;

namespace EternalFleshDecay
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "Jiraya";
        public override string Name { get; } = "EternalFleshDecay";
        public override string Prefix { get; } = "EternalFleshDecay";

        public override System.Version Version { get; } = new System.Version(1, 0, 1);
        public override System.Version RequiredExiledVersion { get; } = new System.Version(8, 0, 0);
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        public override void OnEnabled()
        {
            Scp3114.Disguising += OnDisguising;
            Scp3114.Disguised += OnDisguised;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Scp3114.Disguising -= OnDisguising;
            Scp3114.Disguised -= OnDisguised;

            base.OnDisabled();
        }

        private void OnDisguising(DisguisingEventArgs ev)
        {
            ev.Scp3114.DisguiseDuration = Config.DisguiseDuration;
            ev.Scp3114.Identity.ServerResendIdentity();
        }

        private void OnDisguised(DisguisedEventArgs ev)
        {
            ev.Scp3114.DisguiseDuration = Config.DisguiseDuration;
            ev.Scp3114.Identity.ServerResendIdentity();
        }
    }
}