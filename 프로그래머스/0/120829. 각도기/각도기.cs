using System;

public class Solution 
{
    public int solution(int angle) 
    {
        
        if(0<angle && angle<90)
        {
            angle = 1;
            return angle;
        }
        else if(angle==90)
        {
            angle = 2;
            return angle;
        }
        else if(90<angle && angle<180)
        {
            angle = 3;
            return angle;
        }
        else
        {
            angle = 4;
            return angle;
        }
    }
}