using AutoMapper;
using Aveva.Employee.Common.RequestModels;
using AvevaModels = Aveva.Employee.DataContracts.Models;

namespace Aveva.Employee.Api.Configurations
{
    public class MappingProfileConfiguration : Profile
    {
        public MappingProfileConfiguration()
        {
            CreateMap<EmployeeRequestCreate, AvevaModels.Employee>();
            CreateMap<EmployeeRequestUpdate, AvevaModels.Employee>();
        }
    }
}