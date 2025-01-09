using LeaveManagementSystem.Models.LeaveType;

namespace LeaveManagementSystem.Services
{
    public interface ILeaveTypesService
    {
        Task<bool> CheckIfLeaveTypeNameExists(string name);
        Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit);
        Task Create(LeaveTypeCreateVM leaveTypeCreate);
        Task Edit(LeaveTypeEditVM leaveTypeEdit);
        Task<List<LeaveTypeReadOnlyVM>> GetAllAsync();
        Task<T?> GetAsync<T>(int id) where T : class;
        bool LeaveTypeExists(int id);
        Task Remove(int id);
    }
}