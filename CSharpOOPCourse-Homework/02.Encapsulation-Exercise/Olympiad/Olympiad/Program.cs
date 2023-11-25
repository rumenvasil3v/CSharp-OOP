﻿/*
Във футболен турнир за купата на директора са заявили участие Х отбора. Правилата на турнира изискват всеки от отборите да играе 2 мача срещу всеки от останалите отбори.
До момента са изиграни X мача, като отговорникът на турнира е отбелязал кои отбори са участвали в проведените мачове. На него обаче му направило впечатление, че до момента всеки от участващите отбори е изиграл точно по два мача и му станало интересно – какъв е максималният брой на отборите, всеки два от които до този момент не са играли мачове помежду си?
Отговорникът номерирал отборите с числата от 1 до X и е изготвил списък с X двойки числа: mj и nj – номерата на отборите, които са играли един срещу друг в j-тия подред мач.
Да се напише програма, която да изведе M - максималния брой на отборите, всеки два от които до този момент не са играли мачове помежду си. Заедно с това програмата да изведе във възходящ ред M числа, които представляват номерата на отборите, всеки два от които до този момент не са играли мачове помежду си.

Input Format

На първия ред от стандартния вход се въвежда цяло положително число X, a на следващите X реда се въвеждат по две числа mj и nj – номерата на отборите, които са играли един срещу друг в j-тия подред мач.

Constraints

4 ≤ X ≤ 100000
1 ≤ mj, nj ≤ X
mj ≠ nj
1 ≤ j ≤ X.

Output Format

На първия ред на стандартния изход да се изведе числото М - максималния брой на отборите, всеки два от които до този момент не са играли мачове помежду си. На следващия ред да се изведат М числа, разделени с интервал - номерата на тези отбори, подредени във възходящ ред. Ако задачата има няколко решения да се изведе това, което е най-напред в лексикографската подредба относно номерата на отборите.

Sample Input 0

6
6 1
1 3
4 2
5 2
6 5
3 4
Sample Output 0

3
1 4 5


 */

using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int numberOfMatches = int.Parse(Console.ReadLine());

        Dictionary<int, List<int>> dicTeams = new();

        for (int n = 0; n < numberOfMatches; n++)
        {
            int[] teamsArgs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int firstTeam = teamsArgs[0];
            int secondTeam = teamsArgs[1];

            if (!dicTeams.ContainsKey(firstTeam))
            {
                dicTeams.Add(firstTeam, new List<int>());
            }

            dicTeams[firstTeam].Add(secondTeam);

            if (!dicTeams.ContainsKey(secondTeam))
            {
                dicTeams.Add(secondTeam, new List<int>());
            }

            dicTeams[secondTeam].Add(firstTeam);
        }
    }
}