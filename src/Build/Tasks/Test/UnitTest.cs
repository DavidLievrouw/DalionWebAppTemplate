using Cake.Frosting;
using Dalion.WebAppTemplate.Build.Tasks.Restore;

namespace Dalion.WebAppTemplate.Build.Tasks.Test {
    [TaskName(nameof(UnitTest))]
    [Dependency(typeof(InitVersion))]
    [Dependency(typeof(RestorePackages))]
    [Dependency(typeof(UnitTestCSharp))]
    [Dependency(typeof(UnitTestJs))]
    public sealed class UnitTest : FrostingTask<Context> { }
}