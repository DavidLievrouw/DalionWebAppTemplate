using System;
using Cake.Core;
using Cake.Core.IO;

namespace Dalion.WebAppTemplate.Build.Configuration.FileSystem {
    public class ProjectsAndSolutionsProperties : Properties<ProjectsAndSolutionsProperties> {
        private readonly Configuration.AppProperties _container;

        public ProjectsAndSolutionsProperties(ICakeContext context, Configuration.AppProperties container) : base(context) {
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        public FilePath ProductSolution => Context.GetAbsoluteFilePath(_container.FileSystem.SourceDirectory + "/WebAppTemplate.sln");
        public DirectoryPath ProjectDirectory => Context.GetAbsoluteDirectoryPath(_container.FileSystem.SourceDirectory + "/WebAppTemplate");
        public DirectoryPath ReactAppDirectory => Context.GetAbsoluteDirectoryPath(ProjectDirectory + "/App");
        public FilePath ProjectFile => Context.GetAbsoluteFilePath(ProjectDirectory + "/WebAppTemplate.csproj");
        public DirectoryPath PublishDirectory => Context.GetAbsoluteDirectoryPath(_container.FileSystem.DistDirectory + "/Publish");
        public DirectoryPath PublishDirectoryAzure => Context.GetAbsoluteDirectoryPath(PublishDirectory + "/Azure");
    }
}