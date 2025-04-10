using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultingFood.Data
{
    [Table("standard")]
    public class Standard
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}

        [Column("name")]
        public required string Name {get; set;}
        [Column("price")]
        public required double Price {get; set;}
        [Column("daysneeded")]
        public required int DaysNeeded {get; set;}
    }
}
