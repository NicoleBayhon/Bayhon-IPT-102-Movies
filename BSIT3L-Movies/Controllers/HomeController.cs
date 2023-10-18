using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;
using System;

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
           new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", URL = "https://youtu.be/QvrCxnfI5kY?si=W-uPwzvYEuuCvkeh", images="/images/titanic.jpg" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", URL="https://youtu.be/QlJkUPm97q8?si=v9_C5cwciZGRVAbe", images="/images/inception.jpg"},
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama",URL="https://youtu.be/y7d7TCtrdnU?si=lGSdNirBDafblRAc", images="/images/shawshank.jpg" },
            new MovieViewModel { Id = 4, Name = "Cabin in the woods", Rating = "5", ReleaseYear = 2011, Genre = "Horror", URL="https://youtu.be/TnUPdW6PeF8?si=2uUOcgOQ1J47CmpF" , images="/images/cabin.jpg"},
            new MovieViewModel { Id = 5, Name = "Autopsy of jane doe", Rating = "5", ReleaseYear = 2016, Genre = "Horror", URL="https://youtu.be/vWhmf1LH8Io?si=GpwpgR7LPDeB8LbU " , images="/images/autopsy.jpg"},
            new MovieViewModel { Id = 6, Name = "The texas chainsaw massacre", Rating = "4", ReleaseYear = 2022, Genre = "Horror",URL="https://youtu.be/cyxHB9R9bgs?si=8yf8Alw8XDON6qB0" , images="/images/chainsaw.jpg"},
            new MovieViewModel { Id = 7, Name = "50 First Dates", Rating = "5", ReleaseYear = 2004, Genre = "Romance/Comedy",URL=" https://youtu.be/QXghVnJs_Jc?si=AhxkoRhJlViB0M99" , images="/images/5.jpg"},
            new MovieViewModel { Id = 8, Name = "The gangster,the cop,the devil", Rating = "4", ReleaseYear = 2013, Genre = "drama/action", URL="https://youtu.be/OChn0Ru5Mo0?si=yipc1QwNA3y5e5ZP", images="/images/gangster.jpg" },
            new MovieViewModel { Id = 9, Name = "Four Sisters and a Wedding", Rating = "5", ReleaseYear = 1994, Genre = "Rom-com/Comedy drama", URL="https://youtu.be/1jDNHr45HiM?si=uUJlYelRiyeuNSKN" , images="/images/4 sisters.jpg"},
            new MovieViewModel { Id = 10, Name = "It Takes a Man and a Woman", Rating = "5", ReleaseYear = 2013, Genre = "Rom-com",URL="https://youtu.be/mbg0eAZI_0Q?si=K2XlI_DQDrctxK0P" , images="/images/it takes a man and a woman.jpg"},
            new MovieViewModel { Id = 11, Name = "Mean Girls", Rating = "5", ReleaseYear = 2004, Genre = "Comedy/Teen",URL = "https://youtu.be/dCrLCATfeZA?si=gTDRvdTPFFCHbfIp", images="/images/mean girls.png"},
            new MovieViewModel { Id = 12, Name = "Nowhere", Rating = "4", ReleaseYear = 2023, Genre = "Thriller",URL="https://youtu.be/BjCjCizSPlc?si=CKAhEppR9rfb_yDA" , images="/images/nowhere.jpg"},
            new MovieViewModel { Id = 13, Name = "Fractured", Rating = "5", ReleaseYear = 2019, Genre = "Psychological thriller/Thriller", URL="https://youtu.be/ZM2_OvDDezo?si=ufGpglntD1tHJRBg" , images="/images/fractured.jpg"},
            new MovieViewModel { Id = 14, Name = "John Wick", Rating = "5", ReleaseYear = 2014, Genre = "Action", URL="https://youtu.be/E0cTQgS2mEc?si=nbEldevYGO9bmopw", images="/images/john wick.jpg" },
            new MovieViewModel { Id = 15, Name = "The Kissing Booth", Rating = "5", ReleaseYear = 2018, Genre = "TEEN", URL="https://youtu.be/9eXb6jWhMis?si=V1L_5w0KRfE2TU-W", images="/images/kissing booth.jpg" },
            new MovieViewModel { Id = 16, Name = "Camp Sawi", Rating = "5", ReleaseYear = 2016, Genre = "Comedy drama/Comedy", URL="https://youtu.be/wWBT3ss9i7Y?si=yBxyRsjiL8udcoq5", images="/images/campsawi.jpg" }

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

