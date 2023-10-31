class LinkedList {

	constructor() {
		this.first = null;
        this.tail = null;
	}
    
	AddFirst(data) {
        
		this.first = {
			data: data,
			next: this.first
		}
        
        if(this.tail == null)
        {
            this.tail = this.first
        }
        
	}
    
	RemoveFirst() {
        
		let oldNode = this.first
		if(oldNode == null)
			return undefined
        
		this.first = oldNode.next

        if(this.first == null)
        {
            this.tail = null
        }
        
		return oldNode.data
	}
    
	AddLast(data) {
        const newLastNode = {
            data: data,
            next: null,
        }
        
		if(this.first == null)
        {
            this.first = newLastNode
            this.tail = newLastNode
        }
        else
        {
            const oldTail = this.tail
            oldTail.next = newLastNode
            this.tail = newLastNode;
        }
	}

}