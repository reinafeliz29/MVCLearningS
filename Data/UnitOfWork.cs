using MVCDemoS.Interface;
using MVCDemoS.Repository;

namespace MVCDemoS.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationConnectDb _context;

        public UnitOfWork(ApplicationConnectDb context)
        {
            _context = context;
        }
        public ISiteInfoRepository SiteInfoRepository => new SiteInfoRepository(_context);

        public async Task<bool> Complete()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public bool HasChanges()
        {
            _context.ChangeTracker.DetectChanges();
            var changes = _context.ChangeTracker.HasChanges();
            return changes;
        }
    }
}
