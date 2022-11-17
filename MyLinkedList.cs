public class StackUsingLL
{
    public Node? head = null;
    public void AddNode(int d)
    {
        var newNode = new Node(d);

        if(head == null)
            head = newNode;
        else
        {
            var travelNode = head;
            while(travelNode.next != null)
                travelNode = travelNode.next;

            travelNode.next = newNode;
        }
    }

    public void AddNodeAtBeginning(int d)
    {
        var newNode = new Node(d);

         if(head == null)
            head = newNode;
        else
        {
            newNode.next = head;
            head = newNode;
        }        
    }

    public void DeleteNode(int d)
    {
        if(head == null)
            return;
        else if(head.next == null)
        {
            if(head.d == d)
                head = null;
        }
        else
        {
            var travelNode = head;
            while(travelNode != null)
            {
                if(travelNode?.next?.d == d)
                {
                    travelNode.next = travelNode.next.next;
                    return;
                }
                travelNode = travelNode?.next;
            }
        }
    }

    public void Display()
    {
        if(head == null)
            Console.WriteLine("LL is empty");
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