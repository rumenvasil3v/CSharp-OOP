using System.Diagnostics;

Database.Database database = null;
try
{
    database = new Database.Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
}
catch
{
    Console.WriteLine("First exception");
}
finally
{
    if (database is null)
    {
        throw new Exception();
    }
}
