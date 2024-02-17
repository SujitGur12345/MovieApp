using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ?ProfilePictureUrl { get; set; }

        public string ?FullName { get; set; }

         public string ?Bio { get; set; }

        //Relationship Join of Actor & Movies as It is Many to Many Relationship 
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
