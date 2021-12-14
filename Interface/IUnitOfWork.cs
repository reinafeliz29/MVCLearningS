namespace MVCDemoS.Interface
{
    public interface IUnitOfWork
    {
        ISiteInfoRepository SiteInfoRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}
