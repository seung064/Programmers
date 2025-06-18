using System;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[2];
        
        
        for(int i = 0; i<=money/5500; i++)
        {
            if(5500*i<=money && money>0)
            {
                answer[0] = i;
                answer[1] = money%5500;
            }
            else
            {
                answer[0] = 0;
                answer[1] = money;
            }
        }
        return answer;
    }
}