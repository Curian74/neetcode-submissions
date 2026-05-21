public class Node {
    public int val;
    public Node next;

    public Node(int data) {
        this.val = data;
    }

    public Node(){}
}

public class LinkedList {
    private Node head;
    private Node tail;

    public LinkedList() {

    }

    public int Get(int index) {
        var temp = head;
        int c = 0;
        while (temp != null) {
            if (c == index) return temp.val;
            temp = temp.next;
            c++;
        }
        return -1;
    }

    public void InsertHead(int val) {
       var newNode = new Node(val);
       if (head == null)
       head = tail = newNode;
       else {
        newNode.next = head;
        head = newNode;
       }
    }

    public void InsertTail(int val) {
       var n = new Node(val);
       if (head == null) {
         head = n;
         tail = n;
       }
       else {
        tail.next = n;
        tail = n;
       }
    }

    public bool Remove(int index) {
       if (head == null) return false;
       if (index == 0) {
           if (head == tail) tail = null;
           head = head.next;
           return true;
       }
       int c = 0;
       var t = head;
       while (t != null && t.next != null) {
        if (c == index - 1) {
          if (t.next == tail) tail = t;
          t.next = t.next.next;
          return true;
        }
        c++;
        t = t.next;
       };
       return false;
    }

    public List<int> GetValues() {
       var t = head;
       var r = new List<int>();
       while (t != null) {
         r.Add(t.val);
         t = t.next;
       }
       return r;
    }
}