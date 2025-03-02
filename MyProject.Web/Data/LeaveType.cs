﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Data
{
    public class LeaveType : BaseEntity
    {
        [Column(TypeName = "nvarchar(150)")] //[MaxLength(150)]
        public string Name { get; set; }
        public int NumberOfDays { get; set; }
    }
}
