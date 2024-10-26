using Microsoft.AspNetCore.Components;
using Radzen.Blazor;
using Radzen;
using Reconcilor.Application.Interfaces;
using Reconcilor.Application.Services;
using Reconcilor.Application;
using Reconcilor.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Reconcilor.Components.Pages
{
    public class BeltRawBase : ComponentBase
    {
        [Inject] private IReconcilorRepository _repository { get; set; } = default!;
        [Inject] protected DialogService DialogService { get; set; } = default!;
        [Inject] protected NotificationService NotificationService { get; set; }
        [Inject] protected StockPileService stockPileService { get; set; } = default!;

        protected RadzenDataGrid<BeltsRaw> dataGrid;
        protected Variant variant = Variant.Outlined;
        protected BeltsRaw beltsRaw = new();
        protected List<Shaft> shaftList;
        protected List<Shift> shiftList;
        protected IEnumerable<BeltsRaw> BeltsList = Enumerable.Empty<BeltsRaw>();
        protected bool isLoading = false;
        protected DateTime? dateFilter;

        protected override async Task OnInitializedAsync()
        {
            beltsRaw.ProductionDate = DateTime.Now;
            await LoadDataAsync();
        }

        void AlertMessage(string msg, NotificationSeverity severity)
        {
            ShowNotification(new NotificationMessage
            {
                Severity = severity,
                Summary = "Reconcilor",
                Detail = $"{msg ?? "No message"}",
                Duration = 4000
            });
        }

        void ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);
        }

        protected async Task LoadDataAsync()
        {
            try
            {
                isLoading = true;
                shiftList = await stockPileService.GetShiftAsync();
                shaftList = await stockPileService.GetShaftAsync();
                BeltsList = await stockPileService.GetBeltsRawAsync();
            }
            catch (Exception ex)
            {
                AlertMessage("Opening tonnes cannot be less than zero (0)", NotificationSeverity.Warning);
                throw;
            }
            finally
            {
                isLoading = false;
            }
        }

        protected async Task OnFilterChanged()
        {
            if (dateFilter.HasValue)
            {
                BeltsList = await stockPileService.GetBeltsRawAsync();
                BeltsList
                    .Where(o => o.EnteredOn == dateFilter.Value.Date);
            }
            else
            {
                BeltsList = await stockPileService.GetBeltsRawAsync(); // Reset to original data
            }
            await dataGrid.Reload(); // Reload the grid to reflect changes
        }

        protected async Task SubmitData()
        {
            try
            {
                isLoading = true;
                var totalTonnes = ReconUtility.CalculateDryTonnes(beltsRaw.WetTonnes ?? 0, beltsRaw.Moisture ?? 0);
                beltsRaw.Id = 0;
                beltsRaw.EnteredOn = DateTime.Now;
                beltsRaw.EnteredBy = "admin";
                beltsRaw.Tonnes = totalTonnes;

                beltsRaw.Co = ReconUtility.CalculateTotalGrade(beltsRaw.TCo.Value, totalTonnes);
                beltsRaw.Cu = ReconUtility.CalculateTotalGrade(beltsRaw.TCu.Value, totalTonnes);

                var result = _repository.SaveDataAsync(beltsRaw);
                if (result is not null && result.Result is not null)
                {
                    AlertMessage("Belts results saved successfully", NotificationSeverity.Success);
                    beltsRaw = new()
                    { ProductionDate = DateTime.Now };
                    await LoadDataAsync();
                    await dataGrid.Reload();
                }
                else
                {
                    AlertMessage("Error saving rod mill discharge results", NotificationSeverity.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                AlertMessage($"Error: {ex.Message} | Detail: {ex.InnerException ?? null}", NotificationSeverity.Error);
            }
            finally
            {
                isLoading = false;
            }
        }
    }
}
