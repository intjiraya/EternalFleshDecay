using Exiled.API.Features;
using Exiled.Events.Handlers;
using Exiled.Events.EventArgs.Scp3114;
using Exiled.API.Enums;

namespace EternalFleshDecay
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "Jiraya";
        public override string Name { get; } = "EternalFleshDecay";
        public override string Prefix { get; } = "EternalFleshDecay";

        public override System.Version Version { get; } = new System.Version(1, 0, 0);
        public override System.Version RequiredExiledVersion { get; } = new System.Version(8, 8, 0);
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        public override void OnEnabled()
        {
            // Subscribing to the `Scp3114.Disguised` event to handle disguise logic
            Scp3114.Disguised += OnDisguised;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            // Unsubscribing from the `Scp3114.Disguised` event to prevent memory leaks
            Scp3114.Disguised -= OnDisguised;
            base.OnDisabled();
        }

        // Event handler for when SCP-3114 is disguised
        private void OnDisguised(DisguisedEventArgs ev)
        {
            // Setting the disguise duration based on the configuration
            ev.Scp3114.DisguiseDuration = Config.DisguiseDuration;
        }
    }
}
