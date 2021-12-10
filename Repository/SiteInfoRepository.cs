using Microsoft.EntityFrameworkCore;
using MVCDemoS.Data;
using MVCDemoS.Interface;
using MVCDemoS.Models;

namespace MVCDemoS.Repository
{
    public class SiteInfoRepository : ISiteInfoRepository
    {
        private readonly ApplicationConnectDb _context;

        public SiteInfoRepository(ApplicationConnectDb context)
        {
            _context = context;
        }
        public async Task<SiteInfo> GetSiteInfo()
        {

            var dt = _context.SiteInfo.FirstOrDefault();
            return dt;
        }
    }
}
