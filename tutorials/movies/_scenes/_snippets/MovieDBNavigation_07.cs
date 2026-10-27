using Serenity.Navigation;
using MyPages = MovieTutorial.MovieDB.Pages;

[assembly: NavigationMenu(6000, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(6100, "Movie Database/Movies", typeof(MyPages.MoviePage), icon: "fa-video-camera")]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Genre", typeof(MyPages.GenrePage), icon: null)]