/*Create the proper classes for Linked Lists and Nodes. Linked Lists and Nodes should both be Generic classes that only allow one data type to be used for each List. Note that to do so, the class Node<T> will need to be declared within the LinkedList<T>. 

·The LinkedList needs to be able to Add new Nodes to the List
·The Node needs the ability to print its own data
·The LinkedList needs to be able to print the data of all of its Nodes in sequence
·Instantiate at least two LinkedLists that store different types of data, with at least three Nodes each. */

LinkedList<int> list = new LinkedList<int>();
list.Add(9);

class LinkedList<T>   // LinkedList<T> class will need to be a generic class
{
    Node Head;     // Node Head which tracks the "head" of the list.
    
    public class Node
    {
        // Each Node has two properties: T Data and Node Next. 
        public T Data { get; set; } // The data is whatever is actually stored on the Node. 

        public Node next;
    }

    public void Add(T data)  // using an Add method
    {
        Node node = new Node();


    }
    


}