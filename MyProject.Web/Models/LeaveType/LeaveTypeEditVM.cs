using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models.LeaveType
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {

        [Required]
        [Length(4, 150, ErrorMessage = "You have violated the length of the input")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 365, ErrorMessage = "You have violated the range of the input")]
        [Display(Name = "Number of Days")]
        public int NumberOfDays { get; set; }
    }
}
