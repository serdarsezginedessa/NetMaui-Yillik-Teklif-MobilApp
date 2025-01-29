
namespace MauiApp5
{
    public static class Constants
    {
        public static string DataBaseFilename = "Teklif.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite | 
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DataBasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DataBaseFilename);

       
    }
}
