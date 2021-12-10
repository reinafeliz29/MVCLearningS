using MVCDemoS.Models;

namespace MVCDemoS.Interface
{
    public interface ISiteInfoRepository
    {
        Task<SiteInfo> GetSiteInfo();
    }
}
