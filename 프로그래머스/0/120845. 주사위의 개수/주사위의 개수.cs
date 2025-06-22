using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 0;

        
       // int a = n*n*n;
     //   int b = box[0]*box[1]*box[2];
     
        answer = (box[0]/n)*(box[1]/n)*(box[2]/n);
        
        return answer;
        
    }
}