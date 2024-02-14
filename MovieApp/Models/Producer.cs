using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Producer
    {
        [Key]
        public int ActorId { get; set; }
        public string? ProfilePictureUrl { get; set; }

        public string? FullName { get; set; }

        public string? Bio { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
