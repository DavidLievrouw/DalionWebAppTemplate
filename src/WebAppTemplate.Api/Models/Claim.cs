using Dalion.WebAppTemplate.Api.Models.Links;

namespace Dalion.WebAppTemplate.Api.Models {
    public class Claim : ILinkableResource<ClaimHyperlinkType> {
        public string Type { get; set; }
        public string Value { get; set; }
        public Hyperlink<ClaimHyperlinkType>[] Links { get; set; }
    }
}