using System;

public class Solution {
    public int[] solution(string s) {
        int zeroCount = 0;
        int count = 0;
        while(s != "1")
        {
            string replaceStr = s.Replace("0", string.Empty);
            int temp = s.Length - replaceStr.Length;
            zeroCount += temp;
            count++;
            s = Convert.ToString(replaceStr.Length, 2);
        }
        
        int[] answer = new int[] {count, zeroCount};
        return answer;
    }
}