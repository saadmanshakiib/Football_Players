using System.ComponentModel.DataAnnotations;

namespace FootballClub.Models;

public class Player
{
    public int id { get; set; }

    [Required(ErrorMessage = "Name Must Be Given")]
    public string name { get; set; }
    
    [Required(ErrorMessage = "Age Must Be Given")]
    public string age { get; set; }
    
    [Required(ErrorMessage = "Position Must Be Given")]
    public string position { get; set; }
    
    [Required(ErrorMessage = "Current Club Name Must Be Entered")]
    public string currentClub { get; set; }
}
