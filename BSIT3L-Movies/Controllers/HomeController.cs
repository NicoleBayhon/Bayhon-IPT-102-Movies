using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
           new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama" },
            new MovieViewModel { Id = 4, Name = "Cabin in the woods", Rating = "5", ReleaseYear = 2011, Genre = "Horror" },
            new MovieViewModel { Id = 5, Name = "Autopsy of jane doe", Rating = "5", ReleaseYear = 2016, Genre = "Horror" },
            new MovieViewModel { Id = 6, Name = "The texas chainsaw massacre", Rating = "4", ReleaseYear = 2022, Genre = "Horror" },
            new MovieViewModel { Id = 7, Name = "50 First Dates", Rating = "5", ReleaseYear = 2004, Genre = "Romance/Comedy" },
            new MovieViewModel { Id = 8, Name = "The gangster,the cop,the devil", Rating = "4", ReleaseYear = 2013, Genre = "drama/action" },
            new MovieViewModel { Id = 9, Name = "Four Sisters and a Wedding", Rating = "5", ReleaseYear = 1994, Genre = "Rom-com/Comedy drama" },
            new MovieViewModel { Id = 10, Name = "It Takes a Man and a Woman", Rating = "5", ReleaseYear = 2013, Genre = "Rom-com" },
            new MovieViewModel { Id = 11, Name = "Mean Girls", Rating = "5", ReleaseYear = 2004, Genre = "Comedy/Teen" },
            new MovieViewModel { Id = 12, Name = "Nowhere", Rating = "4", ReleaseYear = 2023, Genre = "Thriller" },
            new MovieViewModel { Id = 13, Name = "Fractured", Rating = "5", ReleaseYear = 2019, Genre = "Psychological thriller/Thriller" },
            new MovieViewModel { Id = 14, Name = "John Wick", Rating = "5", ReleaseYear = 2014, Genre = "Action" },
            new MovieViewModel { Id = 15, Name = "The Kissing Booth", Rating = "5", ReleaseYear = 2018, Genre = "TEEN" },
            new MovieViewModel { Id = 16, Name = "Camp Sawi", Rating = "5", ReleaseYear = 2016, Genre = "Comedy drama/Comedy" }

        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

