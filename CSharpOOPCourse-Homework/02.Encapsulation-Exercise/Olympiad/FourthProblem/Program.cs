/*
Учителят по математика на Мадлен ѝ поставил задача за домашна работа да намери число, което отговаря на следното условие: числото трябва да е съставно, а броят на неговите делители да е просто число.
Помогнете на Мадлен да напише програма, която намира броя на всички числа, които отговарят на поставеното по-горе условие и са в интервала от a до b, включително.

Input Format

От първия ред на стандартния вход се въвеждат две цели числа a и b. Числата са разделени с един интервал.

Constraints

1 ≤ a ≤ b ≤ 1014

Output Format

На първия ред на стандартния изход програмата извежда едно цяло число – броя на всички числа, които отговарят на поставеното условие и са в интервала от a до b, включително.

Sample Input 0

1 9
Sample Output 0

2
 */

class Solution
{
    static void Main(String[] args)
    {
        int[] intervals = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int start = intervals[0];
        int end = intervals[1];

        int countOfTrueNumbers = 0;
        for (int n = start; n <= end; n++)
        {
            bool isComposite = false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isComposite = true;
                    break;
                }
            }

            if (!isComposite)
            {
                continue;
            }

            int countOfFactors = 2;
            if (isComposite)
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        countOfFactors++;
                    }
                }

                bool isCompose = false;
                if (countOfFactors == 2 || countOfFactors == 3
                    || countOfFactors == 5 || countOfFactors == 7
                    || countOfFactors == 11 || countOfFactors == 13)
                {
                    isCompose = false;
                }
                else if (countOfFactors % 2 == 0 || countOfFactors % 3 == 0
                    || countOfFactors % 5 == 0 || countOfFactors % 7 == 0
                    || countOfFactors % 11 == 0 || countOfFactors % 13 == 0)
                {
                    isCompose = true;
                }

                if (!isCompose)
                {
                    countOfTrueNumbers++;
                }
            }
        }

        Console.WriteLine(countOfTrueNumbers);
    }
}