using System.IO;
using System;
using System.Text;
using System.Collections.Generic;

public class LinkedListExample
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        int[] A = new int[] { 9,6,3 ,0,3, 1,9, 0 };
        LinkedListNode head = CreateLinkedListNode(A);
        Console.Write(head.printForward());
        Console.WriteLine(" ");
        
        int[] B = new int[]{1,8,4,2,0};
        LinkedListNode head1 = CreateLinkedListNode(B);
        Console.WriteLine(head1.printForward());
        //LinkedListNode mergeList = new LinkedListNode(head.data,null,null);
        //RemoveDuplicate(head);
        //Console.Write(head.printForward());
        //Console.WriteLine(FindElementAt(head,2));
        //Console.WriteLine(head.printForward());
        //PartitionAList(head,4);
        LinkedListNode C = SumTwoLinkedList(head,head1); 
        Console.WriteLine(C.printForward());
    }
    public static void PartitionAList(LinkedListNode A, int x){
        LinkedListNode bigger = null;
        LinkedListNode smaller = null;
        LinkedListNode head;
        while (A!=null){
            if (A.data > x) {
                if (bigger==null) bigger = new LinkedListNode(A.data,null,null); 
                else { 
                        bigger = bigger.AddHead(A.data);
                }
                
            }else{
                if (smaller ==null) smaller = new LinkedListNode(A.data,null,null);
                else { smaller = smaller.AddHead(A.data);}
            }
            A = A.next;
        }
        head = smaller;
        while (smaller.next!=null){
            smaller = smaller.next;
        }
        smaller.next = bigger;
        Console.WriteLine(head.printForward());
        
        
    }
    public static LinkedListNode SumTwoLinkedList(LinkedListNode A, LinkedListNode B)
    {
        int carry = 0;
        LinkedListNode C = null;
        while (A!=null || B!=null){
            int a=0,b=0;
            if (A == null) a = 0; else a = A.data;
            if (B == null) b = 0; else b = B.data;
            
            
            if (C==null) C = new LinkedListNode((a+b+carry)%10,null,null);
            else {
                LinkedListNode temp = new LinkedListNode((a+b+carry)%10,null,null);
                C.next = temp;
               
            }
            if ((a+b+carry)>=10) carry = 1; else carry = 0;
            if (A!=null) A = A.next;
            if (B!=null) B = B.next;
        }
        return C;
    }
    public static int FindElementAt(LinkedListNode A, int k){
        LinkedListNode head = A;
        for (int i= 0 ; i<k ;i++)
            A = A.next;
        while(A.next!=null){
            head = head.next;
            A = A.next;
        }
        return head.data;
    }
    public static void RemoveDuplicate(LinkedListNode A){
        HashSet<int> set = new HashSet<int>();
            LinkedListNode temp = A.next;
            if(temp == null)
                return;
            set.Add(A.data);

            while (temp != null)
            {
                if (set.Contains(temp.data))
                {
                    A.next = temp.next;
                }
                else
                {
                    set.Add(temp.data);
                    A = A.next;
                }
                temp = temp.next;
            }
    }
    public static LinkedListNode CreateLinkedListNode(int[] A){
	    LinkedListNode head = new LinkedListNode(A[0],null,null);
	    for (int i = 1; i<A.Length; i++){
	        LinkedListNode node = new LinkedListNode(A[i],null,null);
	        node.setNext(head);
	        head = node;
	    }
	    return head;
	}
}