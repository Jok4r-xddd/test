using Microsoft.AspNetCore.Components;

namespace LeaveManagementSystem.Models.Period
{
    public class EditPeriodVM : BasePeriodVM
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }
    }
}
