using System.Diagnostics;

namespace TelemetryApp.Configs
{
    public static class DiagnosticsConfig
    {
        public const string ServiceName = "TelemetryApp";
        public static ActivitySource ActivitySource = new(ServiceName);
    }
}
