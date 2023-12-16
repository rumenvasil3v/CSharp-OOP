int[] integers = Console
    .ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int countOfExceptions = 0;
while (countOfExceptions < 3)
{
    string[] command = Console.ReadLine().Split(" ");

    try
    {
        int currentIndex = 0;

        switch (command[0])
        {
            case "Replace":
                currentIndex = int.Parse(command[1]);
                int currentElement = int.Parse(command[2]);
                integers[currentIndex] = currentElement;
                break;
            case "Print":
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);

                int index = 0;
                int[] temporaryArray = new int[endIndex - startIndex + 1];
              
                for (int n = startIndex; n <= endIndex; n++)
                {
                    temporaryArray[index++] = integers[n];
                } 

                Console.WriteLine(string.Join(", ", temporaryArray));
                break;
            case "Show":
                currentIndex = int.Parse(command[1]);
                Console.WriteLine(integers[currentIndex]);
                break;
        }
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("The index does not exist!");
        countOfExceptions++;
    }
    catch (FormatException)
    {
        Console.WriteLine("The variable is not in the correct format!");
        countOfExceptions++;
    }
}

Console.WriteLine(string.Join(", ", integers));