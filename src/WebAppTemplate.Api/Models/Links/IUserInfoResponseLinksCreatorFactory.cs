namespace Dalion.WebAppTemplate.Api.Models.Links {
    public interface IUserInfoResponseLinksCreatorFactory {
        ILinksCreator<UserInfoResponse> Create();
    }
}