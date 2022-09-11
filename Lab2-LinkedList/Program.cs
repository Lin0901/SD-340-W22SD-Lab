/*Create the proper classes for Linked Lists and Nodes. Linked Lists and Nodes should both be Generic classes that only allow one data type to be used for each List. Note that to do so, the class Node<T> will need to be declared within the LinkedList<T>. 

·The LinkedList needs to be able to Add new Nodes to the List
·The Node needs the ability to print its own data
·The LinkedList needs to be able to print the data of all of its Nodes in sequence
·Instantiate at least two LinkedLists that store different types of data, with at least three Nodes each. */

LinkedList<int> intList = new LinkedList<int>();
intList.Add(9);
LinkedList<string> stringList = new LinkedList<string>();
stringList.Add("one");




class LinkedList<T>   // LinkedList<T> class will need to be a generic class
{
    public class Node
    {
        public T Data { get; set; }  // Each Node has two properties: T Data and Node Next.

        public Node next;  // The data is whatever is actually stored on the Node. 
        public Node(T x)
        {
            Data = x;
            next = null;

        }
    }

    Node head;     // Node Head which tracks the "head" of the list.
    int count;

    public LinkedList()
    {
        count = 0;
        head = null;
    }
    public void Add(T data)  // using an Add method
    {
        Node node = new Node(data);
        node.next = head;
        head = node;
        count++;
    }
    
    public void PrintList()
    {
        Node runner = head;
        while (runner != null)
        {
            Console.WriteLine(runner.Data);
            runner = runner.next;
        }
    }

    static void Main(string[] args)
    {
        LinkedList<int> intList = new LinkedList<int>();
        intList.Add(2);
        intList.Add(3);
        intList.Add(7);
        intList.Add(6);
        intList.Add(1);
        intList.PrintList();

        LinkedList<string> stringList = new LinkedList<string>();
        stringList.Add("three");
        stringList.Add("ten");
        stringList.Add("nine");
        stringList.Add("two");

    }


}