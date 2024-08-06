using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Reconcilor.Application.Interfaces;
using Reconcilor.Infrastrcuture.DataContext;

namespace Reconcilor.Application.Services
{
    public class ReconcilorService : IReconcilorRepository
    {
        private readonly ReconcilorContext _reconcilorContext;

        public ReconcilorService(ReconcilorContext reconcilorContext)
        {
            _reconcilorContext = reconcilorContext;
        }

        public async Task<T> DeleteDataAsync<T>(int id) where T : class
        {
            try
            {
                var itemToDelete = await _reconcilorContext.Set<T>().FindAsync(id);
                if (itemToDelete != null)
                {
                    var deletedItem = _reconcilorContext.Remove(itemToDelete);
                    await _reconcilorContext.SaveChangesAsync();
                    return deletedItem.Entity;
                }
                throw new NullReferenceException($"Item with key {id} not found, deleted failed");
            }
            catch (Exception ex)
            {
                var _ = ex.Message;
                throw;
            }
        }

        public async Task<IQueryable<T>> GetDataAsync<T>() where T : class 
        {
            return await Task.FromResult(_reconcilorContext.Set<T>());
        }

        public Task<T> GetDataAsync<T>(int id) where T : class
        {
            throw new NotImplementedException();
        }

        public async Task<T> SaveDataAsync<T>(T entity) where T : class
        {
            try
            {
                var addItem = await _reconcilorContext.AddAsync(entity);
                _reconcilorContext.SaveChanges();
                return addItem.Entity;
            }
            catch (Exception ex)
            {
                var _ = ex.Message;
                throw;
            }
        }

        public async Task<T> UpdateDataAsync<T>(int id, T entity) where T : class
        {
            try
            {
                var itemToDelete = await _reconcilorContext.Set<T>().FindAsync(id);
                if (itemToDelete != null)
                {
                    var itemToUpdate = _reconcilorContext.Update(entity);
                    await _reconcilorContext.SaveChangesAsync();
                    return itemToUpdate.Entity;
                }
                throw new NullReferenceException($"Item with key {id} not found, update failed");
            }
            catch (Exception ex)
            {
                var _ = ex.Message;
                throw;
            }
        }
    }
}
