using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        
        for(int i = 0; i < nums.Length - 2; i++)
        {
            for(int k = i + 1; k < nums.Length - 1; k++)
            {
                for(int j = k + 1; j < nums.Length; j++)
                {
                    int num = nums[i] + nums[k] + nums[j];
                    int count = 0;
                    for(int p = 2; p <= num; p++)
                    {
                        if(num % p == 0)
                        {
                            count++;
                        }
                    }
                    if(count == 1)
                    {
                        answer++;
                    }
                }
            }
        }

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        System.Console.WriteLine(answer);

        return answer;
    }
}