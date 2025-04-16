namespace ConsultingFood.Data
{
    public class Review
    {
        public int Id {get; set;}

        public required string Comment {get; set;}

        public required double Grade {get; set;}

        public DateTime CreatedAt {get; set;}

        public DateTime UpdatedAt {get; set;}
    }
}