namespace CodeChallenges
{
  public class LinkedList
  {
    public Node Head { get; set; }
    public Node Tail { get; set; }
    //Miles "Tails" Prower
    public Node CurrentNode { get; set; }

    //Constructor?

    public void Insert(int val)
    {
      //insert a second node if no head exists
      Node newNode = new Node(val);
      if (Head == null)
      {
        Head = newNode;
        Tail = Head;
      } else //insert after Head node
      {
        newNode.next = Head.next;
        Head.next = newNode;
        newNode.last = Head; // doubly linked update
        Tail = newNode;
      }
    }
    public void InsertAtEnd(int val)
    {
      Node newNode = new Node(val);
      CurrentNode = Head.next;
      while (CurrentNode.next != null)
        {
          CurrentNode = CurrentNode.next;
        }
      CurrentNode.next = newNode;
      newNode.last = CurrentNode;
      Tail = newNode;
    }

    public void InsertHead(int val)
    {
      Node newNode = new Node(val);
      newNode.next = Head;
      Head.last = newNode;
      Head = newNode;



    }

    public void ReadList()
    {
      CurrentNode = Head;
      while(CurrentNode != null)
      {
        Console.Write($"{CurrentNode.value} -> ");
        CurrentNode = CurrentNode.next;
      }
      Console.WriteLine();
    }

    public void ReadListBackwards()
    {
      CurrentNode = Tail;
      while(CurrentNode.last != null)
      {
        Console.Write($" <- {CurrentNode.value}  ");
        CurrentNode = CurrentNode.last;
      }
      Console.WriteLine();
    }


  }

  public class Node
  {
    public int value { get; set; }
    public Node next { get; set; }
    public Node last { get; set; }
    public Node(int v)
    {
      this.value = v;
      this.next = null;
      this.last = null;
    }
  }
}
