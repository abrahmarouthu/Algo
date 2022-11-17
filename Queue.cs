public class MyQueue
{
    int[] arr;
    int fIndex = 0; 
    int rIndex = 0;
    int MAX;
    
    public MyQueue(int m)
    {
        MAX = m;
        arr = new int[MAX];
    }

    public void Enqueue(int d)
    {
        if(rIndex >= MAX)
            Console.WriteLine("Qeueu is full");
        else {
            arr[rIndex] = d;
            rIndex++;
        }

    }

    public void Dequeue()
    {
        if(fIndex > rIndex)
            Console.WriteLine("Qeuue is empty");
        else
            fIndex++;
    }

    public void Display()
    {
        for(int i = fIndex; i < rIndex; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}