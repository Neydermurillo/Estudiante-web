using Soccer.web.Data.Entities;
using Soccer.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.web.Helpers
{
    public interface IConverterHelper
    {
        TeamEntity ToTeamEntity(TeamViewModel model, string path, bool isNew);

        TeamViewModel ToTeamViewModel(TeamEntity teamEntity);

    }
}
