
namespace LeaveManagementSystem.Services
{
    public interface IPeriodsService
    {
        Task Create(CreatePeriodVM periodCreate);
        Task Edit(EditPeriodVM periodCreate);
        Task<List<ReadOnlyPeriodVM>> GetAllAsync();
        Task<T?> GetAsync<T>(int id) where T : class;
        bool PeriodExists(int id);
        Task Remove(int id);
    }
}