using Dalion.WebAppTemplate.Api.Models.Links;

namespace Dalion.WebAppTemplate.Api.Models {
    public class ApiHomeResponse : ILinkableResource<ApiHomeResponseHyperlinkType> {
        public ApplicationInfo ApplicationInfo { get; set; }
        public Hyperlink<ApiHomeResponseHyperlinkType>[] Links { get; set; }
    }
}