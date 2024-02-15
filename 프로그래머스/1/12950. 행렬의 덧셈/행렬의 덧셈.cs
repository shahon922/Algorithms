using System;
public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = new int[arr1.GetLength(0),arr1.GetLength(1)];        
        for(int i = 0; i < arr1.GetLength(0); i++)
        {
            for(int k = 0; k < arr1.GetLength(1); k++)
            {
                answer[i,k] = arr1[i,k] + arr2[i,k];
            }
        }
        return answer;
    }
}