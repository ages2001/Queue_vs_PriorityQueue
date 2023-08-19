namespace PriorityQueue_Project
{
    class PriorityQueue
    {
        private List<int> list;

        public PriorityQueue()
        {
            this.list = new List<int>();
        }

        public bool isEmpty() { return list.Count == 0; }

        public int size() { return list.Count; }

        public void Enqueue(int item) { list.Add(item); }

        public int Dequeue()
        {
            int deletedItem = list[0];

            for (int i = 0; i < size(); i++)
                if (list[i] < deletedItem)
                    deletedItem = list[i];

            list.Remove(deletedItem);
            return deletedItem;
        }

        public void calculateTime()
        {
            const int productTime = 3;
            int totalTime = 0, prevCustomerTime = 0, countCustomers = 0, totalCustomers = size();

            while (!isEmpty())
            {
                prevCustomerTime += Dequeue() * productTime;
                totalTime += prevCustomerTime;

                Console.WriteLine("{0}. customer spent {1} second.", ++countCustomers, prevCustomerTime);
            }

            Console.WriteLine("\nTotal time is {0} second.", totalTime);
            Console.WriteLine("Average time is {0:0.00} second.", (float)totalTime / totalCustomers);
        }
    }
}
