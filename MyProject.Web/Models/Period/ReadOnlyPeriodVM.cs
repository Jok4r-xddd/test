namespace LeaveManagementSystem.Models.Period
{
    public class ReadOnlyPeriodVM : BasePeriodVM
    {
        public string Name { get; set; }

        [Display(Name = "Start Date")]
        public DateOnly StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateOnly EndDate { get; set; }
    }
}
