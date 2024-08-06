namespace Reconcilor.Application.Interfaces
{
    public interface IReconcilorRepository
    {
        Task<IQueryable<T>> GetDataAsync<T>() where T : class;
        Task<T> GetDataAsync<T>(int id) where T : class;
        Task<T> SaveDataAsync<T>(T entity) where T: class;
        Task<T> UpdateDataAsync<T>(int id,T entity) where T : class;
        Task<T> DeleteDataAsync<T>(int id) where T : class;
    }
}
