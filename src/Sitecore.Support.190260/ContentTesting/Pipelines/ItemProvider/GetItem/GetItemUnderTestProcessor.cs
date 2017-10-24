namespace Sitecore.Support.ContentTesting.Pipelines.ItemProvider.GetItem
{
  using Sitecore.ContentTesting;
  public class GetItemUnderTestProcessor : Sitecore.ContentTesting.Pipelines.ItemProvider.GetItem.GetItemUnderTestProcessor
  {
    // allowCache = false;
    public GetItemUnderTestProcessor() : this(false, null)
    {
    }

    public GetItemUnderTestProcessor(bool allowCache, IContentTestingFactory factory = null): base(allowCache, factory)
    {
    }
  }
}