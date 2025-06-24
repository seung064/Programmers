using System;

public class Solution {
    public string solution(string my_string) {

        
        
        char[] a = my_string.ToCharArray();
        for(int i = 0; i<my_string.Length; i++)
        {
            if(char.IsLower(a[i]))
            {
                a[i] = char.ToUpper(a[i]);
            }
            else
            {
                a[i] = char.ToLower(a[i]);
            }
        }
        
        string answer = new string(a);
        return answer;
    }
}