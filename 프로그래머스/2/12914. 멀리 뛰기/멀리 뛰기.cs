public class Solution {
    public long solution(int n) {
        long[] answer = new long[2000];
        answer[0] = 1;
        answer[1] = 2;
        
        for(int i = 2; i < n; i++)
        {
            answer[i] = (answer[i - 2] + answer[i - 1]) % 1234567;
        }
        return answer[n - 1];
    }
}