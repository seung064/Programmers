using System;

public class Solution {
    public string solution(string my_string) {
        //string answer = "";
        //return answer;
        
        //char[] s = new char[] {'a','e','i','o','u'};
        my_string = my_string.Replace("a", "");
        my_string = my_string.Replace("e", "");
        my_string = my_string.Replace("i", "");
        my_string = my_string.Replace("o", "");
        my_string = my_string.Replace("u", "");
        return my_string;
    }
}