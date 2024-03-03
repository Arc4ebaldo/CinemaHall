using test2.Models;
using test2.Repositories;
using test2.Services;
using test2.View;

namespace test2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

            // FilmService filmService = new FilmService();
            // Film film = filmService.GetFilmByName("Drive").ToFilm();
            // HallService hallService = new HallService();
            // Hall hall = hallService.GetHallByName("Red").ToHall();
            // SeansRepo seansRepo = new SeansRepo();
            // Seans seans = new Seans(
            //     DateTime.Parse("01.01.2001 01:01"),
            //     TimeSpan.Parse("02:02"),
            //     hall,
            //     film
            // );
            // seansRepo.Create(seans);
            // Console.WriteLine(film.Title);
            // using (ApplicationContext context = new())
            // {
            //     Film film = context.Films.Where(f => f.Title == "Drive").First();
            //     Hall hall = context.Halls.Where(h => h.Name == "Red").First();
            //     Seans seans = new Seans(
            //         DateTime.Parse("01.01.2001 01:01"),
            //         TimeSpan.Parse("02:02"),
            //         hall,
            //         film
            //     );
            //     // context.Seanses.Remove(context.Seanses.First());
            //     // context.Seanses.Add(seans);
            //     // context.SaveChanges();
            // }
            // using (ApplicationContext context = new()) {
            //     Console.WriteLine(context.Seanses.First().Film.Title);
            // }
        }
    }
}