using System;

class CustomQueue
{
    private int[] items;  
    private int front;
    private int rear;
    private int maxSize;

    
    public CustomQueue(int size)
    {
        maxSize = size;
        items = new int[maxSize];
        front = -1;
        rear = -1;
    }

    
    public bool IsFull()
    {
        return rear == maxSize - 1;
    }

    
    public bool IsEmpty()
    {
        return front == -1 || front > rear;
    }

    
    public void Enqueue(int value)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is full. Cannot enqueue " + value);
        }
        else
        {
            if (front == -1)
                front = 0; 
            rear++;
            items[rear] = value;
            Console.WriteLine(value + " enqueued to the queue.");
        }
    }

   
    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty. Cannot dequeue.");
            return -1;
        }
        else
        {
            int item = items[front];
            front++;
            if (front > rear)
            {
                
                front = rear = -1;
            }
            return item;
        }
    }

    
    public void DisplayQueue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
        }
        else
        {
            Console.Write("Queue elements: ");
            for (int i = front; i <= rear; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        CustomQueue queue = new CustomQueue(5);

        
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);
        queue.Enqueue(60);  

        
        queue.DisplayQueue();

  
        Console.WriteLine("Dequeued: " + queue.Dequeue());
        Console.WriteLine("Dequeued: " + queue.Dequeue());

        
        queue.DisplayQueue();
    }
}
