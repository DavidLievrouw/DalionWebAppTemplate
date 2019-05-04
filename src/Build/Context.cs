using Cake.Core;
using Cake.Frosting;
using Dalion.WebAppTemplate.Build.Configuration;

namespace Dalion.WebAppTemplate.Build {
    public class Context : FrostingContext {
        public Context(ICakeContext context) : base(context) {
            App = new AppProperties(context);
        }

        public AppProperties App { get; }
    }
}