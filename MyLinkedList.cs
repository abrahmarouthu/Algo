public class LinkedListClass
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

    public void AddNodeUsingRecursive(int d) => head = AddNodeUsingRecursiveHelper(head, d);
    // {
    //     head = AddNodeUsingRecursiveHelper(head, d);
    // }

    public Node AddNodeUsingRecursiveHelper(Node travelNode, int d)
    {
        if(travelNode == null)
        {
            var newNode = new Node(d);
            travelNode = newNode;
            return travelNode;
        }
        else
            travelNode.next = AddNodeUsingRecursiveHelper(travelNode.next, d);

        return travelNode;
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

    public void DisplayUsingRecursive()
    {
        DisplayUsingRecursiveHelper(head);
    }

    public void DisplayUsingRecursiveHelper(Node node)
    {
        if(node == null)
        {
            Console.WriteLine();
            return;
        }

        Console.Write(node.d + "->");
        DisplayUsingRecursiveHelper(node.next);
    }
}