using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int[] nums = new int[num2-num1+1];
        Array.Copy(numbers,num1,nums,0,(num2-num1+1));
        return nums;
        
        /* 삭제인줄,,,
        var nums = new List<int>();
        for(int i = 0; i<numbers.Length; i++)
        {
            nums.Add(numbers[i]);    
        }
        
        nums.RemoveRange(num1,num2);
        int[] array = nums.ToArray();
        
        return array;
        */
    }
}