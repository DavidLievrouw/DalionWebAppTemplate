using System;
using System.Net.Http;

namespace Dalion.WebAppTemplate.Api.Models.Links {
    public interface IHyperlinkFactory {
        Hyperlink<TRel> Create<TRel>(HttpMethod method, string href, TRel rel)
            where TRel : struct, IConvertible;
    }
}