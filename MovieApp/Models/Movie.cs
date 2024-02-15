﻿using MovieApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }


        //Relationship Join of Actor & Movies as It is Many to Many Relationship 
        public List<Actor_Movie> Actor_Movies { get; set; }


        //Cinema as it One to Many Relation
        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]

        public Cinema Cinema { get; set; }


        //Producer as it One to Many Relation
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]


        public Producer Producer { get; set; }

    }
}
