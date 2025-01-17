using UFC.UseCases.FighterRequests;
using UFC.UseCases.FighterRequests.Interfaces;
using UFC.UseCases.Fighters;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.Filters;
using UFC.UseCases.Filters.Interfaces;

namespace UFC.WebApp.Extensions
{
    public static class UseCaseServiceExtensions
    {
        public static IServiceCollection AddUseCaseServices(this IServiceCollection services)
        {
            // Fighter Use Cases
            services.AddTransient<IViewFightersByNameUseCase, ViewFightersByNameUseCase>();
            services.AddTransient<
                IViewOutdatedFightersByNameUseCase,
                ViewOutdatedFightersByNameUseCase
            >();
            services.AddTransient<IViewFighterByIdUseCase, ViewFighterByIdUseCase>();
            services.AddTransient<IViewBaseFightersUseCase, ViewBaseFightersUseCase>();
            services.AddTransient<IAddFighterUseCase, AddFighterUseCase>();
            services.AddTransient<IAddAlterEgoFighterUseCase, AddAlterEgoFighterUseCase>();
            services.AddTransient<IUpdateFighterUseCase, UpdateFighterUseCase>();
            services.AddTransient<IDeleteFighterUseCase, DeleteFighterUseCase>();
            services.AddTransient<ISetFighterStatOutdatedUsecase, SetFighterStatOutdatedUsecase>();
            services.AddTransient<ISetFighterStatUpdatedUsecase, SetFighterStatUpdatedUsecase>();

            // FighterRequest Use Cases
            services.AddTransient<
                IViewFighterRequestsByNameUseCase,
                ViewFighterRequestsByNameUseCase
            >();
            services.AddTransient<IViewFighterRequestByIdUseCase, ViewFighterRequestByIdUseCase>();
            services.AddTransient<IUpdateFighterRequestUseCase, UpdateFighterRequestUseCase>();
            services.AddTransient<IDeleteFighterRequestUseCase, DeleteFighterRequestUseCase>();
            services.AddTransient<IAddFighterRequestUseCase, AddFighterRequestUseCase>();

            // Fighter Filter Use Cases
            services.AddTransient<ISetStandUpFilterUseCase, SetStandUpFilterUseCase>();
            services.AddTransient<ISetFightersAsQueryableUseCase, SetFightersAsQueryableUseCase>();
            services.AddTransient<IGetFightersAsQueryableUseCase, GetFightersAsQueryableUseCase>();
            services.AddTransient<ISetFighterStyleFilterUseCase, SetFighterStyleFilterUseCase>();
            services.AddTransient<
                ISetFighterDivisionFilterUseCase,
                SetFighterDivisionFilterUseCase
            >();
            services.AddTransient<ISetFighterPerkFilterUseCase, SetFighterPerkFilterUseCase>();
            services.AddTransient<IResetFilterQueryUseCase, ResetFilterQueryUseCase>();

            return services;
        }
    }
}
