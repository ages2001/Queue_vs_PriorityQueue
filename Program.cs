namespace PriorityQueue_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQUEUE\n*****\n");

            QueueClass queueList = new QueueClass();

            queueList.Enqueue(8); queueList.Enqueue(9); queueList.Enqueue(6); queueList.Enqueue(7); queueList.Enqueue(10); queueList.Enqueue(1);
            queueList.Enqueue(11); queueList.Enqueue(5); queueList.Enqueue(3); queueList.Enqueue(4); queueList.Enqueue(2);

            queueList.calculateTime();

            Console.WriteLine("\n\nPRIORITY QUEUE\n**************\n");

            PriorityQueue pqList = new PriorityQueue();

            pqList.Enqueue(8); pqList.Enqueue(9); pqList.Enqueue(6); pqList.Enqueue(7); pqList.Enqueue(10); pqList.Enqueue(1);
            pqList.Enqueue(11); pqList.Enqueue(5); pqList.Enqueue(3); pqList.Enqueue(4); pqList.Enqueue(2);

            pqList.calculateTime();
        }
    }
}
