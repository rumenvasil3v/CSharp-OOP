/*
aaa 2 3.4 5 invalid 24 -4
 */

string[] sequenceOfElements = Console.ReadLine().Split(" ");

int totalSumOfAllIntegers = 0;
foreach (string currentSequence in sequenceOfElements)
{
    try
    {
        int currentNumber = int.Parse(currentSequence);
        totalSumOfAllIntegers += currentNumber;
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"The element '{currentSequence}' is in wrong format!");
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"The element '{currentSequence}' is out of range!");
    }
    finally
    {
        Console.WriteLine($"Element '{currentSequence}' processed - current sum: {totalSumOfAllIntegers}");
    }
}

Console.WriteLine($"The total sum of all integers is: {totalSumOfAllIntegers}");