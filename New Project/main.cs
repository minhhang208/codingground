using System.IO;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        //Console.WriteLine(GetBitAtPosition(766031L,2));
        //Console.WriteLine(SetBitAtPosition(766031L,5));
        //Console.WriteLine(ClearBitAtPosition(766031L,2));
        //string original = "10000000010";
        //string insert = "10011";
        //int i = 2, j = 6;
        //int N = BitUtils.StringToInt(original);
        //int M = BitUtils.StringToInt(insert);
        //BitUtils.PrintNumBinary(InsertMToN(N,M,i,j));
        //Console.WriteLine(DoubleToBinaryString(0.25));
        string original = "100010111010";
        int N = BitUtils.StringToInt(original);
        string insert =   "100000100010";
        int M = BitUtils.StringToInt(insert);
        //Console.WriteLine(NumberOfBitDifferent(M,N));
        //int countBit = GetNumberOf1Bits(N);
        //Console.WriteLine(GetNextSmallest(countBit));
        //Console.WriteLine(GetNextLargest(countBit));
        //BitUtils.PrintNumBinary(GetNextLargest(countBit));
        int i = (int)(N & 0xaaaaaaaa)>>1;
        int j = (int)(N & 0x55555555)<<1;
         BitUtils.PrintNumBinary((int)(N & 0xaaaaaaaa)>>1);
         BitUtils.PrintNumBinary(i|j);
    }
    public static bool getBitAtPosition(int number, int i){
        return 1<<i&number!=0
    }
    public static int GetMissingNumber(int[] A){
        StringBuilder s = new StringBuilder();
        for (int i =0; i< A.length; i++){
            int count = 0;
            for (int j = 0; j < 32; j++)
                if (getBitAtPosition(A[i],j)) count ++
            }
            if (count< A.length)
                
        }
    }
    public static int SwapOddAndEven(int N){
        for (int i=1; i<=16; i++){
            
        }
        return 1;
    }
    public static int NumberOfBitDifferent(int N, int M){
        int differ = N ^ M;
        return (GetNumberOf1Bits(differ));
    }
    public static int GetNumberOf1Bits(int number) {
        int count = 0;
        for (int i = 1; i<=32; i++)
            count += ((number & (1<<i))>0?1:0);
        return count;
    }
    public static int GetNextSmallest(int count){
        return (1<<count+1) -1;
    }
    public static int GetNextLargest(int count){
        return GetNextSmallest(count)<<30-count;
    }
    public static string DoubleToBinaryString(double d){
        StringBuilder s = new StringBuilder();
        s.Append(".");
        while(d>0){
            if (s.Length >= 32){
                Console.Error.WriteLine("Error");
                return "";
            }
            d = d*2;
            if (d>=1){
                s.Append("1");
                d -= 1;
            } else
            {
                s.Append("0");
            }
        }
        return s.ToString();
        
    }

    
    public static int ClearBitFromIToJ(int number, int i, int j){
        int allOnes = ~0;
        int clearFrom0toJ = allOnes << (j+1);
        int allOnefromOtoI = (1<<i)-1;
        int mask = clearFrom0toJ | allOnefromOtoI;
        return number & mask;
    }
    public static int InsertMToN(int N, int M, int i, int j){
        //move M to correct position
        int mask = M << i;
        BitUtils.PrintNumBinary(mask);
        //clear bit from i to j in N
        N = ClearBitFromIToJ(N,i,j)|mask; 
        return  N;
    }
    
    //get bit at a position
    public static bool GetBitAtPosition(long l, int i){
        return ((l&1<<i)!=0);
    }
    //set bit at a position
    public static long SetBitAtPosition(long l, int i){
        return (l|(1<<i));
    }
    //clear bit at a position
    public static long ClearBitAtPosition(long l, int i){
        long mask = ~(1<<i);
        return (mask & l);
    }
    //clear bit from most significal bit through i
    public static long ClearBitAtMostSignifical(long l, int i){
        long mask = (1<<(i+1)) -1;
        return (mask&l);
    }
    //clear all bit from i to 0
    public static long ClearBitFromIthrough0(long l, int i){
        long mask = ~(1<<(i+1)-1);
        return (mask&l);
    }

}
