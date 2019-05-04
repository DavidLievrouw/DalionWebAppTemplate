using FakeItEasy;

namespace Dalion.WebAppTemplate {
    public static partial class ExtensionsForT {
        public static T Fake<T>(this T reference) where T : class {
            return A.Fake<T>();
        }
    }
}