using Queue;
using Xunit;
using static Queue.LinkedQueue;

namespace QueueTests
{
    public class LinkedQueueTest
    {
        [Fact]
        public void CheckIfOfferMethodReturnTrue()
        {
            LinkedQueue linkedQueue = new LinkedQueue();

            Assert.True(linkedQueue.offer(1));
        }

        [Fact]
        public void CheckIfTheTailValueIsCorrect() 
        {
            LinkedQueue linkedQueue = new LinkedQueue();
            linkedQueue.offer(1);
            linkedQueue.offer(2);
            linkedQueue.offer(3);
            linkedQueue.offer(4);
            Assert.Equal(1, linkedQueue.peek());
        }

        [Fact]
        public void checkIfPeekReturnsCorrectValue() 
        { 
            LinkedQueue linkedQueue = new LinkedQueue(1);
            linkedQueue.offer(1);
            Assert.Equal(1, linkedQueue.peek());
            linkedQueue.offer(2);
            Assert.Equal(1, linkedQueue.peek());
        }

        [Fact]
        public void checkIfPoolDeleteCorrectValue() 
        { 
            LinkedQueue linkedQueue = new LinkedQueue();
            linkedQueue.offer(1);
            linkedQueue.offer(2);
            linkedQueue.pool();
            Assert.Equal(2, linkedQueue.peek());
        }

        [Fact]
        public void unitTestOfPoolMethod() 
        {
            LinkedQueue linkedQueue = new LinkedQueue();
            Assert.Null(linkedQueue.pool());
            linkedQueue.offer(1);
            Assert.NotNull(linkedQueue.pool());
            Assert.Null(linkedQueue.pool());
        }

        [Fact]
        public void TestLinkedQueue() 
        {
            LinkedQueue linkedQueue = new LinkedQueue();
            linkedQueue.offer(1);
            int? firstPoolFromQueue = linkedQueue.pool();
            Assert.Equal(1, firstPoolFromQueue);
            linkedQueue.offer(1);
            linkedQueue.offer(2);
        }
    }
}