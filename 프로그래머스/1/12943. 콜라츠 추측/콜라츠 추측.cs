public class Solution {
    public int solution(int num) {
        int answer = 0;
        double temp = num;
        
        for(int i = 0; i <= 500; i++)
        {
            if(temp == 1)
            {
                return i;
            }
            
            temp = temp % 2 == 0 ? temp / 2 : temp * 3 + 1; 
        }
        answer = -1;
        
        return answer;
    }
}