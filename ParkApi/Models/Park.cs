using System.ComponentModel.DataAnnotations;

namespace ParkApi.Models
{
    public class Park
    {
        [Required(ErrorMessage = "The Name field is required.")]
        public int ParkId { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public string Location { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public string Type { get; set; }
    }
}

