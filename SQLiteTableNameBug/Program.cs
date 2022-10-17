using static Microsoft.EntityFrameworkCore.RelationalEntityTypeExtensions;

namespace SQLiteTableNameBug;

internal class Program
{
    static void Main(string[] args)
    {
        using var db = new BloggingContext();
        db.Database.EnsureCreated();

        var tableName = db.Blogs.EntityType.GetSchemaQualifiedTableName();

        Console.WriteLine($"The table name {tableName} is invalid in SQLite");
    }
}