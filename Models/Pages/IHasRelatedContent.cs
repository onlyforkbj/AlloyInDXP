using EPiServer.Core;

namespace AlloyInDXP.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
