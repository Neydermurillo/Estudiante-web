using Microsoft.AspNetCore.Http;
using Soccer.web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Soccer.web.Models
{
    public class TeamViewModel : TeamEntity
    {
        [Display(Name = "Logo")]
        public IFormFile LogoFile { get; set; }

    }
}
