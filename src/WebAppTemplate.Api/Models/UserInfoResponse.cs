using Dalion.WebAppTemplate.Api.Models.Links;

namespace Dalion.WebAppTemplate.Api.Models {
    public class UserInfoResponse : ILinkableResource<UserInfoResponseHyperlinkType> {
        public Claim[] Claims { get; set; }
        public Hyperlink<UserInfoResponseHyperlinkType>[] Links { get; set; }
    }
}