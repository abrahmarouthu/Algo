    public class MyStack
    {
        int[] arr;
        int top;
        int MAX;

        public MyStack(int m)
        {
            MAX = m;
            arr = new int[MAX];
            top = -1;
        }

        public void Push(int data)
        {
            if(top == MAX-1)
                Console.WriteLine("Stack is full");
            else
            {
                top++;
                arr[top] = data;
            }
        }

        public void Pop()
        {
            if(top == -1)
                Console.WriteLine("Stack is empty");
            else
                top--;
        }

        public void Display()
        {
            for(int i = 0; i <= top; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }



