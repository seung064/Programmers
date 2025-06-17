using System;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        //int answer = 0;
        //return answer;
        Array.Sort(numbers);
        int max1 = numbers[numbers.Length-1];
        int max2 = numbers[numbers.Length-2];
        return max1*max2;
    }
}