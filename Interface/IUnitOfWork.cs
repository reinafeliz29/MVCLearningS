namespace MVCDemoS.Interface
{
    public interface IUnitOfWork
    {
        ISiteInfoRepository SiteInfoRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}
