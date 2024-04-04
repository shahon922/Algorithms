using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>();
        DateTime toDay = DateTime.Parse(today);
        
        Dictionary<string, string> timersDic = new Dictionary<string, string>();
        
        for(int i = 0; i < terms.Length; i++)
        {
            string[] timersS = terms[i].Split(" ");
            timersDic.Add(timersS[0], timersS[1]);
        }
        
        for(int i = 0; i < privacies.Length; i++)
        {
            string[] timersS = privacies[i].Split(" ");
            if(timersDic.TryGetValue(timersS[1], out string value))
            {
                DateTime privacie  = DateTime.Parse(timersS[0]).AddMonths(int.Parse(value));
                if(toDay.CompareTo(privacie) != -1)
                {
                    answer.Add(i + 1);
                }
            }
        }
        answer.Sort();
        return answer.ToArray();
    }
}