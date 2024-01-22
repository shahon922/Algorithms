public class Solution {
    public int[] solution(long n) {
        string x = n.ToString();
        int[] answer = new int[x.Length];
        
        for(int i = 0; i < x.Length; i++)
        {
            answer[i] = (int)(n % 10);
            n = n / 10;
        }
        
        return answer;
    }
}