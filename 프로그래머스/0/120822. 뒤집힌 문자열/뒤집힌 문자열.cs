using System;
/*
string.ToArray()로 string을 배열로 변환
Array.Reverse()로 문자열 배열의 순서 뒤집기
new string()으로 배열을 문자열로 변환
*/

public class Solution {
    public string solution(string my_string) {
        char[] chars = my_string.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);        
    }
}