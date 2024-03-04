using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLongLength(0)];
        
        for(int x = 0; x < commands.GetLongLength(0); x++)
        {
            int i = commands[x, 0];
            int j = commands[x, 1];
            int k = commands[x, 2];
            
            int[] temp = new int[j - i + 1];
            
            for(int y = 0; y < temp.Length; y++)
            {
                temp[y] = array[y + i - 1];
            }
            Array.Sort(temp);
            
            answer[x] = temp[k-1];
        }
        return answer;
    }
}