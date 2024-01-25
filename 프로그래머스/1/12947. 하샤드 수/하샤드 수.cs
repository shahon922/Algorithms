public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int n = 0;
        int i = x;
        
        while( x != 0)
        {
            n += x % 10;
            x = x / 10;
        }
        if(i % n == 0)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        
        return answer;
    }
}