
namespace AlghoritmsAndDataStructures
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

/* using Queue; */
/* using Xunit; */
/* using static Queue.LinkedQueue; */

/* namespace QueueTests */
/* { */
/*     public class LinkedQueueTest */
/*     { */
/*         [Fact] */
/*         public void CheckIfOfferMethodReturnTrue() */
/*         { */
/*             LinkedQueue linkedQueue = new LinkedQueue(); */

/*             Assert.True(linkedQueue.offer(1)); */
/*         } */

/*         [Fact] */
/*         public void CheckIfTheTailValueIsCorrect() */ 
/*         { */
/*             LinkedQueue linkedQueue = new LinkedQueue(); */
/*             linkedQueue.offer(1); */
/*             linkedQueue.offer(2); */
/*             linkedQueue.offer(3); */
/*             linkedQueue.offer(4); */
/*             Assert.Equal(1, linkedQueue.peek()); */
/*         } */

/*         [Fact] */
/*         public void checkIfPeekReturnsCorrectValue() */ 
/*         { */ 
/*             LinkedQueue linkedQueue = new LinkedQueue(1); */
/*             linkedQueue.offer(1); */
/*             Assert.Equal(1, linkedQueue.peek()); */
/*             linkedQueue.offer(2); */
/*             Assert.Equal(1, linkedQueue.peek()); */
/*         } */

/*         [Fact] */
/*         public void checkIfPoolDeleteCorrectValue() */ 
/*         { */ 
/*             LinkedQueue linkedQueue = new LinkedQueue(); */
/*             linkedQueue.offer(1); */
/*             linkedQueue.offer(2); */
/*             linkedQueue.pool(); */
/*             Assert.Equal(2, linkedQueue.peek()); */
/*         } */

/*         [Fact] */
/*         public void unitTestOfPoolMethod() */ 
/*         { */
/*             LinkedQueue linkedQueue = new LinkedQueue(); */
/*             Assert.Null(linkedQueue.pool()); */
/*             linkedQueue.offer(1); */
/*             Assert.NotNull(linkedQueue.pool()); */
/*             Assert.Null(linkedQueue.pool()); */
/*         } */

/*         [Fact] */
/*         public void TestLinkedQueue() */ 
/*         { */
/*             LinkedQueue linkedQueue = new LinkedQueue(); */
/*             linkedQueue.offer(1); */
/*             int? firstPoolFromQueue = linkedQueue.pool(); */
/*             Assert.Equal(1, firstPoolFromQueue); */
/*             linkedQueue.offer(1); */
/*             linkedQueue.offer(2); */
/*         } */
/*     } */
/* } */
