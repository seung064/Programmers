using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        //int answer = 0;
        //return answer;
        
        List<int> a = new List<int>();
        
        
        for(int i =0; i<numbers.Length; i++)
        {
            for(int j=i+1; j<numbers.Length; j++)
            {
                a.Add(numbers[i]*numbers[j]);          
            }
        }
        return a.Max();
        
    }
}