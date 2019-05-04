namespace Dalion.WebAppTemplate.Api.Models.Links {
    public interface IClaimLinksCreatorFactory {
        ILinksCreator<Claim> Create();
    }
}