using System;

public class Node {
    public int Value {get;set;}
    public Node Next = null;
    public Node(int value) {
        Value = value;
        Next = null;
    }
    
}