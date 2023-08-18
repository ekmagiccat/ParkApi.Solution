using System.ComponentModel.DataAnnotations;

namespace ParkApi.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
    }
}

