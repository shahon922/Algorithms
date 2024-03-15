using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] human1 = new int[5] {1, 2, 3, 4, 5};
        int[] human2 = new int[8] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] human3 = new int[10] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int[] answer = new int[3] {0,0,0};
        
        for(int i = 0; i < answers.Length; i++)
        {
            if(human1[i % 5] == answers[i]) {answer[0]++;}
            if(human2[i % 8] == answers[i]) {answer[1]++;}
            if(human3[i % 10] == answers[i]) {answer[2]++;}
        }
        int max = 0;
        for(int i = 0; i < 3; i++)
        {
            if(max < answer[i])
            {
                max = answer[i];
            }
        }
        List<int> list = new List<int>();
        
        for(int i = 0; i < 3; i++)
        {
            if(max == answer[i])
            {
                list.Add(i+1);
            }
        }
        return list.ToArray();
    }
}