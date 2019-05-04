using Cake.Core;
using Dalion.WebAppTemplate.Build.Configuration.Arguments;
using Dalion.WebAppTemplate.Build.Configuration.FileSystem;

namespace Dalion.WebAppTemplate.Build.Configuration {
    public class AppProperties : Properties<AppProperties> {
        public AppProperties(ICakeContext context) : base(context) {
            Arguments = new ArgumentsProperties(context, this);
            FileSystem = new FileSystemProperties(context, this);
            WorkingDirectory = context.Environment.WorkingDirectory.FullPath;
        }

        public string WorkingDirectory { get; }
        public string ProductName { get; } = "Dalion.WebAppTemplate";
        public string ProductVersion { get; set; } = "1.0.0";
        public string AssemblyVersion { get; set; } = "1.0.0.0";

        public ArgumentsProperties Arguments { get; }
        public FileSystemProperties FileSystem { get; }
    }
}