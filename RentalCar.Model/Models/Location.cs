using System.ComponentModel.DataAnnotations;

namespace RentalCar.Model.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(256)]
        public string Address { get; set; }
        
        public int WardId { get; set; }
        
        public Ward Ward { get; set; }
    }
}