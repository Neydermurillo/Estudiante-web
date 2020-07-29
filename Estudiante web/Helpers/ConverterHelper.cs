using Soccer.web.Data.Entities;
using Soccer.web.Models;

namespace Soccer.web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public TeamEntity ToTeamEntity(TeamViewModel model, string path, bool isNew)
        {
            return new TeamEntity
            {
                Id = isNew ? 0 : model.Id,
                LogoPth = path,
                Name = model.Name
            };
        }

        public TeamViewModel ToTeamViewModel(TeamEntity teamEntity)
        {
            return new TeamViewModel
            {
                Id = teamEntity.Id,
                LogoPth = teamEntity.LogoPth,
                Name = teamEntity.Name
            };
        }

    }
}
