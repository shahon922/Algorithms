using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] elements) {
        int answer = 0;
        List<int> list = new List<int>();
        int[] temp = new int[1000000];
        
        for (int i = 1; i <= elements.Length; i++) {
            for (int j = 0; j < elements.Length; j++) {
                int sum = 0;
                for (int k = 0; k < i; k++) {
                    if (j + k >= elements.Length) {
                        sum += elements[j + k - elements.Length];
                    }
                    else
                        sum += elements[j + k];
                }
                if (temp[sum] == 0) {
                    list.Add(sum);
                    temp[sum] = 1;
                }
            }
        }
        
        answer = list.Count();
        return answer;
    }
}