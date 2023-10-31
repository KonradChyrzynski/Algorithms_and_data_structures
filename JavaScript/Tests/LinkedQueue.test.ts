/*const linkedQueue = require('../LinkedQueue');
test('check if queue is empty', () => 
    {
        const queue = new linkedQueue();
        queue.enqueue(5);
        queue.dequeue();
        expet(
            queue.peek()).toBe(null);
    }
)*/

const { LinkedQueue } = require('../LinkedQueue');

describe('LinkedQueue', () => {
    it('should enqueue and dequeue items', () => {
        const queue = new LinkedQueue();

        queue.enqueue(1);
        queue.enqueue(2);

        expect(queue.peek()).toBe(1);
        expect(queue.dequeue()).toBe(1);
        expect(queue.peek()).toBe(2);
        expect(queue.dequeue()).toBe(2);
    });

    it('should return null when dequeuing from an empty queue', () => {
        const queue = new LinkedQueue();
        expect(queue.dequeue()).toBe(null || undefined);
    });

    it('should return null when peeking into an empty queue', () => {
        const queue = new LinkedQueue();
        expect(queue.peek()).toBe(null || undefined);
    });
});