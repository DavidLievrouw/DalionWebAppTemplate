using System;

namespace Dalion.WebAppTemplate.Api.Models {
    public interface ILinkableResource<TRel> where TRel : struct, IConvertible {
        Hyperlink<TRel>[] Links { get; set; }
    }
}