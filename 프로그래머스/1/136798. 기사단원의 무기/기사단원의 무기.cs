using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        for (int i = 1; i <= number; i++)
        {
            int count = 0;

            for (int k = 1; k * k <= i; k++)
                if (i % k == 0)
                {
                    if (i / k == k)
                    {
                        count++;
                    }
                    else
                    {
                        count += 2;
                    }
                }

            if (count <= limit)
                answer += count;
            else
                answer += power;
        }
        return answer;
    }
}