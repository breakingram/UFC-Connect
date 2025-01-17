using UFC.CoreBusiness.FighterRequestModel;
using UFC.CoreBusiness.FighterRequestModel.ViewModel;

namespace UFC.UseCases.PluginInterfaces;

public interface IFighterStatusFilterRepository
{
    Task SetFightersAsQueryable(IQueryable<FighterRequestViewModel> query);
    Task SetFighterStatusFilter(FighterUpdateStatusEnum? status);
    Task<IQueryable<FighterRequestViewModel>> GetFightersAsQueryable();
    Task<List<FighterRequestViewModel>> CreateFightersStatusList();

    Task<List<FighterRequestViewModel>> GetCurrentUserFighterRequestList(string userId);
    Task SetFighterRequestViewFilter(FighterRequestViewEnum? view);

    Task SetCurrentUser(string userId);

    Task ResetQuery();
}
