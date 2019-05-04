using System;

namespace Dalion.WebAppTemplate.Utils {
    public interface ILocalTimeConverter {
        DateTime ToLocalDateTime(DateTimeOffset input);
    }
}