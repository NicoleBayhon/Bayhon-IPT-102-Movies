using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
                new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", Description="The movie is about the 1912 sinking of the RMS Titanic. It stars Kate Winslet and Leonardo DiCaprio. The two play characters who are of different social classes. They fall in love after meeting aboard the ship, but it was not good for a rich girl to fall in love with a poor boy in 1912." },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller",Description="Cobb (Leonardo DiCaprio) is a corporate raider of the highest order. He infiltrates the minds of other men to steal their ideas. Now he is hired by a powerful billionaire to do the opposite: To introduce an idea into a rival's mind, and do it so well he believes it is his own." },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama", Description=" In 1947, Andy Dufresne (Tim Robbins), a banker in Maine, is convicted of murdering his wife and her lover, a golf pro. Since the state of Maine has no death penalty, he is given two consecutive life sentences and sent to the notoriously harsh Shawshank Prison." },
            new MovieViewModel { Id = 4, Name = "Cabin in the woods", Rating = "5", ReleaseYear = 2011, Genre = "Horror", Description="Curt (Chris Hemsworth) and a rambunctious group of college friends steal away for a weekend of debauchery in an isolated cabin, only to be attacked by horrific supernatural creatures in a night of endless terror" },
            new MovieViewModel { Id = 5, Name = "Autopsy of jane doe", Rating = "5", ReleaseYear = 2016, Genre = "Horror", Description="The Autopsy of Jane Doe is a 2016 supernatural horror film directed by André Øvredal. It stars Brian Cox and Emile Hirsch as father-and-son coroners who experience supernatural phenomena while examining the body of an unidentified woman (played by Olwen Kelly). It is Øvredal's first English-language film." },
            new MovieViewModel { Id = 6, Name = "The texas chainsaw massacre", Rating = "4", ReleaseYear = 2022, Genre = "Horror" , Description="After 48 years of hiding, Leatherface returns to terrorize a group of idealistic young friends who accidentally disrupt his carefully shielded world in a remote Texas town. In 1974, The World Witnessed One of the Most Bizarre Crimes in the Annals of American History. In 2022, The Face of Madness Returns."},
            new MovieViewModel { Id = 7, Name = "50 First Dates", Rating = "5", ReleaseYear = 2004, Genre = "Romance/Comedy" , Description="It follows the story of Henry, a womanizing marine veterinarian who falls for an art teacher named Lucy. When he discovers she has amnesia, and forgets him when she falls asleep, he resolves to win her over again each new day."},
            new MovieViewModel { Id = 8, Name = "The gangster, the cop, the devil", Rating = "4", ReleaseYear = 2013, Genre = "drama/action" , Description = "The film stars Ma Dong-seok, Kim Mu-yeol and Kim Sung-kyu. In the film, a gangster and a cop join forces to catch a serial killer, but face challenges from their respective enemies at work."},
            new MovieViewModel { Id = 9, Name = "Four Sisters and a Wedding", Rating = "5", ReleaseYear = 2013, Genre = "Rom-com/Comedy drama" , Description="After a few years of not being together as a whole family, they find themselves reuniting when CJ announces his plan to marry Princess (Angeline Quinto), his girlfriend for three months. CJ's sisters come together for the planned wedding and have agreed to dissuade him from marrying his fiancée." },
            new MovieViewModel { Id = 10, Name = "It Takes a Man and a Woman", Rating = "5", ReleaseYear = 2013, Genre = "Rom-com" , Description = "It takes a man and a woman is about the love story of Miggy played by John Lloyd Cruz and Laida played by Sarah Geronimo after their break up which happen after the second film. Miggy is in a new relationship with Belle played by Isabelle Daza while Laida is a working woman living in the United States."},
            new MovieViewModel { Id = 11, Name = "Mean Girls", Rating = "5", ReleaseYear = 2004, Genre = "Comedy/Teen" , Description = "Lindsay Lohan plays a teen girl trying to get along at a new high school. This time, she plays a girl home schooled in Africa, whose first experience at a public school is marred by a clique of nasty girls called the Plastics, who use gossip and other torture techniques to try to ruin her social life."},
            new MovieViewModel { Id = 12, Name = "Nowhere", Rating = "4", ReleaseYear = 2023, Genre = "Thriller" , Description = "The father and daughter notice the raft holding baby Noa and reel it in to discover the infant still alive and relatively well given the circumstances. They then discover a thin line attached to the raft that is submerged below the water and are eventually able to pull Mia's unconscious body from the sea."},
            new MovieViewModel { Id = 13, Name = "Fractured", Rating = "5", ReleaseYear = 2019, Genre = "Psychological thriller/Thriller" , Description = "It stars Sam Worthington, Lily Rabe, Stephen Tobolowsky, Adjoa Andoh, and Lucy Capri. It follows the story of Ray Monroe, who tries finding his missing wife and daughter after suffering a head injury that twists his perception of reality. The film had its world premiere at Fantastic Fest on September 22, 2019."},
            new MovieViewModel { Id = 14, Name = "John Wick", Rating = "5", ReleaseYear = 2014, Genre = "Action" , Description = "John Wick is a 2014 American action thriller film directed by Chad Stahelski and written by Derek Kolstad. Keanu Reeves stars as John Wick, a legendary hitman who comes out of retirement to seek revenge against the men who killed his puppy, a final gift from his recently deceased wife."},
            new MovieViewModel { Id = 15, Name = "The Kissing Booth", Rating = "5", ReleaseYear = 2018, Genre = "TEEN" , Description = "A high school student is forced to confront her secret crush at a kissing booth. Elle falls for her best friend's older brother. But there's a catch... it breaks rule #9. She tries to hide her feelings but all breaks loose when Elle and her best friend Lee organise a charity kissing booth."},
            new MovieViewModel { Id = 16, Name = "Camp Sawi", Rating = "5", ReleaseYear = 2016, Genre = "Comedy drama/Comedy" , Description = "Reeling from heartache, a group of women checks in to a boot camp to rehabilitate their views on romance and find themselves -- together."}
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

