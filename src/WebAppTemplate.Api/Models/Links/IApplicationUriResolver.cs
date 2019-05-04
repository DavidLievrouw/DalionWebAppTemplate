using System;

namespace Dalion.WebAppTemplate.Api.Models.Links {
    public interface IApplicationUriResolver {
        Uri Resolve();
    }
}