using Microsoft.EntityFrameworkCore;
using Reconcilor.Domain.Models;
using Reconcilor.Domain.ViewModels;
using Reconcilor.Infrastrcuture.DataContext;

namespace Reconcilor.Application.Services
{
    public class StockPileService
    {
        private readonly ReconcilorContext _reconcilorContext;

        public StockPileService(ReconcilorContext reconcilorContext)
        {
            _reconcilorContext = reconcilorContext;
        }

        public async Task<IEnumerable<StockPileViewModel>> GetStockPileBinAsync()
        {
            return await _reconcilorContext.StockPileViewModel
                .FromSqlRaw("SELECT [s].[Id], [s].[ClosingTonnes], [s].[DateFrom], [s].[DateTo], [s].[EnteredBy], [s].[EnteredOn], [s].[OpeningTonnes], [s].[StockPId], [b].[BinName] " +
                "FROM [StockPiles] AS [s] INNER JOIN [Bin] AS [b] ON [s].[StockPId] = [b].[StockPId]").ToListAsync();
        }

        public async Task<IEnumerable<Bin>> GetBinAsync()
        {
            return await _reconcilorContext.Bins
                                 .ToListAsync();
        }

        public async Task<List<Shift>> GetShiftAsync()
        {
            try
            {
                var query = await _reconcilorContext.Shifts.ToListAsync();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Shaft>> GetShaftAsync()
        {
            return await _reconcilorContext.Shafts
                                 .ToListAsync();
        }

        public async Task<List<BeltsRaw>> GetBeltsRawAsync()
        {
            return await _reconcilorContext.BeltsRaws
                        .Include(s => s.Shaft)
                        .Include(x => x.Shift)
                                 .ToListAsync();
        }

        public async Task<List<UGStopeDetail>> GetStopeDetailsync()
        {
            return await _reconcilorContext.UGStopeDetails
                        .Include(d => d.StopeDef)
                        .Include(s => s.StopeDef.Shaft)
                        .Include(l => l.StopeDef.Level)
                        .Include(m => m.StopeDef.Mining)
                        .Include(n => n.StopeDef.MineModel)
                        .ToListAsync();
        }

        public async Task<List<StopeDefinition>> GetStopeDefinationsync()
        {
            return await _reconcilorContext.StopeDefinitions
                        .Include(s => s.Shaft)
                        .Include(l => l.Level)
                        .Include(m => m.Mining)
                        .Include(n => n.MineModel)
                                 .ToListAsync();
        }

        public async Task<List<Level>> GetLevelsAsync()
        {
            return await _reconcilorContext.Levels
                        .Include(s => s.Shaft)
                                 .ToListAsync();
        }

        public async Task<List<Mining>> GetMiningAsync()
        {
            return await _reconcilorContext.Minings
                                 .ToListAsync();
        }

        public async Task<List<MineModel>> GetMineModelAsync()
        {
            return await _reconcilorContext.MineModels
                                 .ToListAsync();
        }
        
    }
}
