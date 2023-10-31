namespace Queue 
{
    public class LinkedQueue
    {
        private int capacity { get; set; }
        private int size { get; set; }
        private QueueNode? head { get; set; }
        private QueueNode? tail { get; set; }

        public LinkedQueue(int _capacity)
        {
            capacity = _capacity;
        }

        public LinkedQueue()
        {
            capacity = 10;
        }

        public class QueueNode
        {
            public int value;
            public QueueNode? next;
            public QueueNode(int _value)
            {
                this.value = _value;
                this.next = null;
            }
        }

        // O(1)
        public bool offer(int value)
        {
            if (size < capacity)
            {
                QueueNode? newNode = new QueueNode(value);

                if (head == null)
                {
                    this.head = newNode;
                    this.tail = newNode;
                }
                if (head != null)
                {
                    tail.next = newNode;
                    tail = newNode;
                }
                size++;
                return true;
            }
            else
            {
                Console.WriteLine("Sorry the queue is full");
                return false;
            }
        }

        // O(1)
        public int? peek() 
        {
            return head.value;
        }

        // O(1)
        public int? pool() 
        {
            if (head == null || size == 0) return null;
            QueueNode node = head;
            head = node.next;
            return node.value;
        }
    }
}
