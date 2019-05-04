namespace Dalion.WebAppTemplate.Api.Models.Links {
    public interface IApiHomeResponseLinksCreatorFactory {
        ILinksCreator<ApiHomeResponse> Create();
    }
}