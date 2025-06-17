using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] array, int height) 
    {
        //int answer = 0;
        //return answer;
        array = array.Concat(new int[] {height}).ToArray();
        Array.Sort(array);
        Array.Reverse(array);
        int a = Array.IndexOf(array, height);
        return a;
    }
}