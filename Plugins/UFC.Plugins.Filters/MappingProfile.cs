using AutoMapper;
using UFC.CoreBusiness.Filters;

namespace UFC.Plugins.Filters;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<FighterStandUpFilter, FighterStandUpFilter>();
        CreateMap<FighterGrapplingFilter, FighterGrapplingFilter>();
        CreateMap<FighterHealthFilter, FighterHealthFilter>();
    }
}
