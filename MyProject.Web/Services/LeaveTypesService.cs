using AutoMapper;
using LeaveManagementSystem.Data;
using LeaveManagementSystem.Models.LeaveType;
using Microsoft.EntityFrameworkCore;
using MyProject.Web.Data;

namespace LeaveManagementSystem.Services
{
    public class LeaveTypesService(ApplicationDbContext _context, IMapper _mapper) : ILeaveTypesService
    {

        public async Task<List<LeaveTypeReadOnlyVM>> GetAllAsync()
        {
            var data = await _context.LeaveTypes.ToListAsync();
            var viewData = _mapper.Map<List<LeaveTypeReadOnlyVM>>(data);
            return viewData;
        }

        public async Task<T?> GetAsync<T>(int id) where T : class
        {
            var data = await _context.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);

            if (data == null)
                return null;

            var viewData = _mapper.Map<T>(data);

            return viewData;
        }

        public async Task Remove(int id)
        {
            var data = await _context.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);

            if (data != null)
            {
                _context.Remove(data);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Edit(LeaveTypeEditVM leaveTypeEdit)
        {
            var leaveType = _mapper.Map<LeaveType>(leaveTypeEdit);
            _context.Update(leaveType);
            await _context.SaveChangesAsync();
        }

        public async Task Create(LeaveTypeCreateVM leaveTypeCreate)
        {
            var leaveType = _mapper.Map<LeaveType>(leaveTypeCreate);
            _context.Add(leaveType);
            await _context.SaveChangesAsync();
        }

        public bool LeaveTypeExists(int id)
        {
            return _context.LeaveTypes.Any(e => e.Id == id);
        }
        public async Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit)
        {
            return await _context.LeaveTypes.AnyAsync(x => x.Name.ToLower().Equals(leaveTypeEdit.Name.ToLower()) && x.Id != leaveTypeEdit.Id);
        }
        public async Task<bool> CheckIfLeaveTypeNameExists(string name)
        {
            return await _context.LeaveTypes.AnyAsync(x => x.Name.ToLower().Equals(name.ToLower()));
        }
    }
}
