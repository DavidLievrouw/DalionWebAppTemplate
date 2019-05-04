using System;

namespace Dalion.WebAppTemplate.Utils {
    public static partial class Extensions {
        public static bool Contains(this string source, string value, StringComparison comparisonType) {
            return source.IndexOf(value, comparisonType) >= 0;
        }
    }
}