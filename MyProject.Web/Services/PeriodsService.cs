using AutoMapper;
using LeaveManagementSystem.Models.LeaveType;
using Microsoft.EntityFrameworkCore;
using MyProject.Web.Data;

namespace LeaveManagementSystem.Services
{
    public class PeriodsService(ApplicationDbContext _context, IMapper _mapper) : IPeriodsService
    {


        public async Task<List<ReadOnlyPeriodVM>> GetAllAsync()
        {
            var data = await _context.Periods.ToListAsync();
            var viewData = _mapper.Map<List<ReadOnlyPeriodVM>>(data);
            return viewData;
        }

        public async Task<T?> GetAsync<T>(int id) where T : class
        {
            var data = await _context.Periods.FirstOrDefaultAsync(x => x.Id == id);

            if (data == null)
                return null;

            var viewData = _mapper.Map<T>(data);

            return viewData;
        }

        public async Task Remove(int id)
        {
            var data = await _context.Periods.FirstOrDefaultAsync(x => x.Id == id);

            if (data != null)
            {
                _context.Remove(data);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Edit(EditPeriodVM periodEdit)
        {
            var period = _mapper.Map<Period>(periodEdit);
            _context.Update(period);
            await _context.SaveChangesAsync();
        }

        public async Task Create(CreatePeriodVM periodCreate)
        {
            var period = _mapper.Map<Period>(periodCreate);
            _context.Add(period);
            await _context.SaveChangesAsync();
        }

        public bool PeriodExists(int id)
        {
            return _context.Periods.Any(e => e.Id == id);
        }

    }
}
