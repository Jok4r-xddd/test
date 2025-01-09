using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models.LeaveType
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    {
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Number of Days")]
        public int NumberOfDays { get; set; }
    }
}
