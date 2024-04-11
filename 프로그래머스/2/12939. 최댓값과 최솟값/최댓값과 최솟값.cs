using System;
using System.Linq;
public class Solution {
    public string solution(string s) {
        int[] temp = s.Split(' ').Select(int.Parse).ToArray();
        string answer = temp.Min().ToString() + " " + temp.Max().ToString();
        
        return answer;
    }
}