﻿public class Leve1_04
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 1; i < n / 2; i++)
            {
                if (n % i == 0) answer += i;
            }
            answer += n % 2 == 0 ? n / 2 : 0;

            answer += n;

            return answer;
        }
    }
}
