using System.Diagnostics;
using Xunit;

namespace Dalion.WebAppTemplate {
    public sealed class FactForDebugOnlyAttribute : FactAttribute {
        public FactForDebugOnlyAttribute() {
            if (!Debugger.IsAttached) {
                Skip = "Only running in interactive mode.";
            }
        }
    }
}