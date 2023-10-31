class QueueNode {
    value: number;
    private _next: QueueNode | null;

    constructor(value: number) {
        this.value = value;
        this._next = null;
    }

    get next(): QueueNode | null {
        return this._next;
    }

    set next(node: QueueNode | null) {
        this._next = node;
    }
}

class LinkedQueue
{
    #head;
    #tail;

    public enqueue(value)
    {
        if (this.#head === undefined)
        {
            this.#head = new QueueNode(value);
            this.#tail = this.#head;
            return true;
        }
       
        if(this.#tail !== undefined)
        {
            this.#tail.next = new QueueNode(value);
            this.#tail = this.#tail.next;
        }
    }

    public peek()
    {
        return this.#head?.value;
    }

    public dequeue()
    {        
        const dequeueed = this.#head?.value;

        if(dequeueed !== undefined)
        {
            this.#head = this.#head?.next;
        }

        return dequeueed;
    }
}

export {LinkedQueue}