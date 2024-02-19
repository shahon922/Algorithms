public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min =n;
        int max =m;
        int temp=0;
        while(m>0)
        {
            temp =n%m;
            n=m;
            m=temp;
        }
        answer[0]=n;
        answer[1]=min*max/n;
        return answer;
    }
}