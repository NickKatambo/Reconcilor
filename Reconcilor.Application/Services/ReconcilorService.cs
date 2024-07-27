using Reconcilor.Application.Interfaces;

namespace Reconcilor.Application.Services
{
    public class ReconcilorService : IReconcilorRepository
    {
        public Task<T> DeleteDataAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetDataAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetDataAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> SaveDataAsync<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateDataAsync<T>(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
