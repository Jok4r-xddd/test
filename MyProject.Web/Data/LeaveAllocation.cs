using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace LeaveManagementSystem.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public AppUser Employee {get;set;}
        public string EmployeeId { get; set; }
        public Period Period { get; set; }
        public int PeriodId { get; set; }

        public int NumberOfDays { get; set; }
    }
}
