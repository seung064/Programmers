using System;

public class Solution 
{
    
    public string solution(string my_string, string letter) 
    {
        //string answer = "";
        //return answer;
        //int index = my_string.IndexOf(letter);
        my_string = my_string.Replace(letter, "");
        return my_string;
    }
}