using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultingFood.Data
{
    [Table("appointment")]
    public class Appointment
    {
        public int Id {get; set;}

        public DateTime CreatedAt{get; set;}
        
        public DateTime UpdatedAt {get; set;}

        public required string  Message {get; set;}

        public bool IsActive {get; set;}
    }
}