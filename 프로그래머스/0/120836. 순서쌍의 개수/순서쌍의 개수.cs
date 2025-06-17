using System;

public class Solution 
{
    public int solution(int n) 
    {
        //int answer = 0;
       // return answer;
        
        int count =0;
        for(int a=1; a<=n; a++)
        {
                if(n%a==0)
                {
                    count++;
                }
        }
        return count;
    }
    
}