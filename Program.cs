using test2.Models;
using test2.Repositories;

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
            Application.Run(new FilmForm());
            // FilmRepo filmRepo = new();
            // Console.WriteLine(filmRepo.GetById(2).ReleaseYear);
        }
    }
}