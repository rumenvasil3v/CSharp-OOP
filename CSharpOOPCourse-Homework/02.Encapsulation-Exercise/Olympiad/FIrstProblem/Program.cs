/*
Иванчо си написал една дълга редица, съставена само от нули и единици и се зачудил колко на брой са подредиците на тази редица, които съдържат точно n на брой нули. Подредиците се състоят от последователни елементи на дадената редица.
Напишете програма, която намира броя на всички подредици, които съдържат точно n на брой нули.

Input Format

От първия ред на стандартния вход се въвежда редица R, съставена от нули и единици.
От втория ред на стандартния вход се въвежда цяло число n.

Constraints

Дължината на R ≤ 106
n ≤ дължината на R

Output Format

На първия ред на стандартния изход програмата трябва да изведе цяло число, показващо броя на всички подредици, които съдържат точно n на брой нули.
 */
class Solution
{
    static void Main(String[] args)
    {
        string r = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        string str = string.Empty;

        int count = 0;
        for (int i = 0; i < r.Length; i++)
        { 
            string currentString = string.Empty;
            currentString += r[i];

            for (int j = i; j < r.Length - 1; j++)
            {
                currentString += r[j];
                if (currentString.Contains(new string('0', 2)))
            }
        }

        Console.WriteLine(count);
    }
}