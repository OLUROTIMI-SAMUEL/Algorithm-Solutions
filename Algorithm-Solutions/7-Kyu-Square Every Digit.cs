using System;

public class Kata
{

    public static int SquareDigits(int n)
    {
        //conerting to string
        String num = Convert.ToString(n);
        //  initialising an empty string
        string result = "";
        //looping through the string
        for (int i = 0; i < num.Length; i++)
        {
            //get the numeric value off each character
            //square it concaente the squre it to result 
            result += Math.Pow(char.GetNumericValue(num[i]), 2).ToString();
        }
        //convert result to integer
        int res = Convert.ToInt32(result);
        return res;
    }
}