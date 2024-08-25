using Exiled.API.Interfaces;
using System.ComponentModel;

namespace EternalFleshDecay
{
    public class Config : IConfig
    {
        [Description("Plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Enable debug?")]
        public bool Debug { get; set; } = false;

        [Description("Time in seconds that SCP-3114 remains disguised. Default - '3.40282347E+38'")]
        public float DisguiseDuration { get; set; } = float.MaxValue;
    }
}
