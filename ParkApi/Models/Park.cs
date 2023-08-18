using System.ComponentModel.DataAnnotations;

namespace ParkApi.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public string ParkLocation { get; set; }
        public string ParkType { get; set; }
    }
}

