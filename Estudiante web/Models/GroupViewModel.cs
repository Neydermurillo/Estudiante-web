using Soccer.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.web.Models
{
    public class GroupViewModel : GroupEntity
    {
        public int TournamentId { get; set; }
    }
}
