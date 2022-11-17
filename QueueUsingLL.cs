public class QueueUsingLL
{
    public Node? front = null;
    public Node? rear = null;
    public void Enqueue(int d)
    {
        var newNode = new Node(d);
        if(rear == null)
        {
            front = newNode;
            rear = newNode;
        }
        else
        {
            rear.next = newNode;
            rear = newNode;
        }
    }

    public void Dequeue()
    {
        if(front == null)
            return;
        else
        {
            if(front.next == null)
            {
                front = null;
                rear = null;
            }
            else
                front = front.next;
        }
    }

    public void Display()
    {
        if(front == null)
            Console.WriteLine("Queue is empty");
        else
            {
                var travelNode = front;
                while(travelNode != null)
                {
                    Console.Write(travelNode.d + "->");
                    travelNode = travelNode.next;
                }
                Console.WriteLine();
            }
    }
}