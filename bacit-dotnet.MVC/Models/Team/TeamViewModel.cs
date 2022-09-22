using System.ComponentModel.DataAnnotations;

namespace bacit_dotnet.MVC.Models.Team
{
    public class TeamViewModel
    {
        public int TeamId { get; set; } 
        public string TeamName { get; set; } = default!;

        //Employee
        [Required]
        public string Name { get; set; } = default!;
        
    }
}
