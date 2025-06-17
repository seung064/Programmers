using System;

public class Solution 
{
    public int solution(int[] sides) 
    {

        Array.Sort(sides);
        Array.Reverse(sides);
        int a = sides[0];
        int b = sides[1];
        int c = sides[2];
/*
        int aa = Math.Pow(a,2);
        int bb = Math.Pow(b,2);
        int cc = Math.Pow(c,2);
      */ 
        if(a<b+c)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
}