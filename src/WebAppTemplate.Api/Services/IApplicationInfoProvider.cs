using Dalion.WebAppTemplate.Api.Models;

namespace Dalion.WebAppTemplate.Api.Services {
    public interface IApplicationInfoProvider {
        ApplicationInfo Provide();
    }
}