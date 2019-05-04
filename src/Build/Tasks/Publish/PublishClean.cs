using Cake.Common.IO;
using Cake.Frosting;

namespace Dalion.WebAppTemplate.Build.Tasks.Publish {
    [TaskName(nameof(PublishClean))]
    public sealed class PublishClean : FrostingTask<Context> {
        public override void Run(Context context) {
            context.CleanDirectory(context.App.FileSystem.DistDirectory);
        }
    }
}