namespace Reconcilor.Application.Interfaces
{
    public interface IReconcilorRepository
    {
        Task<IQueryable<T>> GetDataAsync<T>();
        Task<T> GetDataAsync<T>(int id);
        Task<T> SaveDataAsync<T>(T entity);
        Task<T> UpdateDataAsync<T>(int id,T entity);
        Task<T> DeleteDataAsync<T>(int id);
    }
}
