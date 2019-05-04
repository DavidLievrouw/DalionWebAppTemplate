using System.Reflection;

namespace Dalion.WebAppTemplate.Startup {
    internal class BootstrapperSettings {
        public string EnvironmentName { get; set; }
        public bool UseDetailedErrors { get; set; }
        public Assembly EntryAssembly { get; set; }
    }
}