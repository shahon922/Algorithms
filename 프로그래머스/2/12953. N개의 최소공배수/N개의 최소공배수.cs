public class Solution {
    public int CommonMultiple(int a,int b)
    {
        int n =a;
        int m =b;
        int temp=0;
        while(m>0)
        {
            temp =n%m;
            n=m;
            m=temp;
        }
        return (a*b)/n;
    }
    public int solution(int[] arr) {
        int answer = CommonMultiple(arr[0],arr[1]);
        for(int i=2; i<arr.Length; i++)
        {
            answer = CommonMultiple(answer,arr[i]);
        }
        return answer;
    }
}