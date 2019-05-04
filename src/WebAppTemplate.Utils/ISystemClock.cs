using System;

namespace Dalion.WebAppTemplate.Utils {
    public interface ISystemClock {
        DateTimeOffset UtcNow { get; }
        DateTime LocalNow { get; }
    }
}