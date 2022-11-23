public class StackUsingLL
{
    public Node? head = null;
    public Node? top = null;

    public void Push(int data)
    {
        var newNode = new Node(data);
        if(head == null)
        {
            top = newNode;
            head = newNode;
        }
        else
        {
            top.next = newNode;
            top = newNode;
        }

    }

    public void Pop()
    {
        if(head == null)
            return;
        else
        {
            if(head.next == null)
            {
                head = null;
                top = null;
            }
            else
            {
                var travelNode = head;
                while(travelNode != null)
                {
                    if(travelNode.next.next == null)
                    {
                        travelNode.next = null;
                        top = travelNode;
                        break;
                    }
                    else
                        travelNode = travelNode.next;
                }
            }
        }
    }

    public void Display()
    {
        if(head == null)
            Console.WriteLine("Stack is empty");
        else
            {
                var travelNode = head;
                while(travelNode != null)
                {
                    Console.Write(travelNode.d + "->");
                    travelNode = travelNode.next;
                }
                Console.WriteLine();
            }
    }
    
}