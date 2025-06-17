using System;

public class Solution {
    public int solution(int slice, int n) {
        //int answer = 0;
        //return answer;

        
        for(int count=1; count<=n; count++)
        {
            if(count*slice>=n)
            {
                return count;
            }
        }
        return 0;
    }
}