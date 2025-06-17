using System;

public class Solution {
    public int solution(int n) {
        //int answer = 0;
        //return answer;
        int i = 0;
        if(n<=7)
        {
            i=1;
        }
        else if(n > 7 && n%7 == 0)
        {
            i = n/7;
        }
        else if(n > 7 && n%7 > 0)
        {
            i = 1 + n/7;
        }
        return i;
        
    }
}