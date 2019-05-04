using System.Threading.Tasks;

namespace Dalion.WebAppTemplate.Api.Models.Links {
    public interface ILinksCreator<in TModel> {
        Task CreateLinksFor(TModel model);
    }
}