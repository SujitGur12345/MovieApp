using MovieApp.Models;

namespace MovieApp.Data
{
    //Seed ===> Initalizing Data in DB
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Reference to AppDB File To Get Data / Add Data
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "",
                            Description = "This is the description of tht first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "",
                            Description = "This is the description of tht first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "",
                            Description = "This is the description of tht first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "",
                            Description = "This is the description of tht first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "",
                            Description = "This is the description of tht first cinema"
                        }


                    });
                    //Save All Data to DB
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            ProfilePictureUrl = "",
                            Bio = "This is Actor 1"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            ProfilePictureUrl = "",
                            Bio = "This is Actor 2"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            ProfilePictureUrl = "",
                            Bio = "This is Actor 3"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            ProfilePictureUrl = "",
                            Bio = "This is Actor 4"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            ProfilePictureUrl = "",
                            Bio = "This is Actor 5"
                        },
                    });
                    //Save All Data to DB
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of second actor",
                            ProfilePictureUrl = ""
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of second actor",
                            ProfilePictureUrl = ""
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of second actor",
                            ProfilePictureUrl = ""
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of second actor",
                            ProfilePictureUrl = ""
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of second actor",
                            ProfilePictureUrl = ""
                        },



                    });
                    //Save All Data to DB
                    context.SaveChanges();

                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Shinchan",
                            Description = "This is an Fun Loving Cartoon",
                            Price = 38.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID = 3,
                            MovieCategory = Enums.MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Equalizer",
                            Description = "This is the most high action packed movie of Denzel Washington",
                            Price = 480,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 3,
                            ProducerID = 5,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Conjuring",
                            Description = "This is the Horror Based movie",
                            Price = 88.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 4,
                            ProducerID = 4,
                            MovieCategory = Enums.MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie",
                            Price = 38.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID = 2,
                            MovieCategory = Enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Ace Ventura",
                            Description = "This is the most funny movie with aka Jimmy carey in the house",
                            Price = 38.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID = 1,
                            MovieCategory = Enums.MovieCategory.Comedy
                        },
                    });
                    //Save All Data to DB
                    context.SaveChanges();
                }
                //Actor_Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },
                    });
                    //Save All Data to DB
                    context.SaveChanges();
                }



            }
        }
    }
}
