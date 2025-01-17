using UFC.CoreBusiness.FighterModel;

namespace UFC.WebApp.Services.Interfaces;

public interface IFighterPropertyPathService
{
    List<string> GetAllPropertyPaths(Fighter fighter);
}
