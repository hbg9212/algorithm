﻿public class Leve1_03
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            while (n % 10 > 0 || n >= 10)
            {
                answer += n % 10;
                n = n / 10;
            }

            return answer;
        }
    }
}
