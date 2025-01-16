using AutoMapper;
using LeaveManagementSystem.Data;
using LeaveManagementSystem.Models.LeaveType;

namespace LeaveManagementSystem.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //LeaveTyoe Mappers
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();

            //Period Mappers
            CreateMap<Period, ReadOnlyPeriodVM>();
            CreateMap<CreatePeriodVM, Period>();
            CreateMap<EditPeriodVM, Period>().ReverseMap();
        }
    }
}
