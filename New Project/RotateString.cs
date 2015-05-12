using System;
public static class StringUtil {
    
    public static string recursiveRotate(char[] arrayString,int start, int end){
        if (start<end) {
            char temp = arrayString[end];
            arrayString[end] = arrayString[start];
            arrayString[start] = temp;
             return recursiveRotate(arrayString,start+1, end -1);
        }else {
            return new string(arrayString);
            
        }
    }
}