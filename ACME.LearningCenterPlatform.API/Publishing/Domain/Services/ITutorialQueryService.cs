using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Queries;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Services;

public interface ITutorialQueryService
{
    Task<Tutorial?> Handle(GetCategoryByIdQuery query);
    Task<IEnumerable<Tutorial>> Handle(GetAllTutorialsQuery query);
    Task<IEnumerable<Tutorial>> Handle(GetAllTutorialsByCategoryIdQuery query);
}