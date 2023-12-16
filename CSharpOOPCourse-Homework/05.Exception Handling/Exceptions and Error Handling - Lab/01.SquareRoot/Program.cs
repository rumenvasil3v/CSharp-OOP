
try
{
    int number = int.Parse(Console.ReadLine());

    if (number < 0)
    {
        throw new ArgumentOutOfRangeException("Invalid number.");
    }
    else
    {
        Console.WriteLine(Math.Sqrt(number));
    }
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.ParamName);
}
finally
{
    Console.WriteLine("Goodbye.");
}