using System.IO;
using System;

public static class BitUtils {
    public static int StringToInt(string s){
        return Convert.ToInt32(s,2);
    }
    public static void PrintNumBinary(int i) {
        Console.WriteLine(Convert.ToString(i,2));
    }
}