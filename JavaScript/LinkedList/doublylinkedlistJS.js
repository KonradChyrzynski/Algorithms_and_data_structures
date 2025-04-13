class DoublyLinkedList {

    static node = class
    {
        constructor(data, next = null, prev = null){
            this.data = data;
            this.next = next;
            this.prev = prev;
        }
    }

    constructor(){
        this.head = null;
        this.tail = null;
        this.size = 0;
    }

    // Insert first node
    //Tested
    insertFirst(data){
        let newNode = new DoublyLinkedList.node(data, this.head) 
        if(this.size == 0)
        {   
            this.head = newNode;
            this.tail = this.head;
        }
        else
        {
            this.head.prev = newNode;
            this.head = newNode;
        }
        this.size++;
    }

    // Insert last node
    //Tested
    insertLast(data)
    {
        this.tail = new DoublyLinkedList.node(data,null,this.tail);
        if(this.size == 0)
            this.head = this.tail;
        else
            this.tail.prev.next = this.tail;
        this.size++;
    }

    insertAt(data,index)
    {
        if(index != undefined)
        {
            if(index == 0 )
            {
                this.insertFirst(data)
                return;
            }
            if(index == this.size - 1)
            {
                this.insertLast(data);
                return;
            }
    
            let count = 0;
            let current = this.head;

            while(count < index)
            {
                current = current.next;
                count++;
            }

            let newNode = new DoublyLinkedList.node(data,current, current?.prev);
            current.prev.next = newNode;
            current.prev = newNode;
            this.size++;
        }
    }

    searchAt(index)
    {

        let half = Math.ceil(this.size / 2);
        if(index > half)
        {
            let current = this.tail;
            let count = this.size - index - 1;
            while(count != 0)
            {
                current = current.prev
                count--;
            }
            return current;
        }
        else
        {
            let current = this.head;
            let count = 0;
            while(count < index)
            {
                current = current.next;
                count++;
            }
            return current;
        }
    }

    reverseBySwitchingNumbers()
    {
        let 
            half = Math.floor(this.size / 2),
            left = this.head,
            right = this.tail;

        for(let counter = 1; counter <= half; counter++)
        {
            let temp = left.data;
            left.data = right.data;
            right.data = temp;
            
            left = left.next;
            right = right.prev;
        }
    }

    reverseBySwitchingNumbersFast()
    {
        let left = this.head,
            right = this.tail;
        for(
            let fast = this.head;
            fast?.next != null;
            fast = fast.next.next
        ){
            let temp = left.data;
            left.data = right.data;
            right.data = temp;
            
            left = left.next;
            right = right.prev;
            }
    }
    // Insert at index

    reverseBySwitchingReference()
    {
        for(let el1 = this.head, el2; el1 != null; el1 = el2)
        {
            el2 = el1.next;
            el1.next = el1.prev;
            el1.prev = el2;
        }

        let temp = this.head;
        this.head = this.tail;
        this.tail = temp;
    }

    //Tested
    bubblesort()
    {
        for(let swap = true; swap;)
        {
            swap = false;
            for(let left = this.head, right = this.head.next; right != null; left = right, right = left.next )
            {
                if(left.data > right.data)
                {
                    let temp = left.data;
                    left.data = right.data;
                    right.data = temp;
                    swap = true;
                }
            }
        }
    }

    // Get at index
    getAt(index){
        let current = this.head;

        let count = 0;

        while(current){
            if(count == index){
                console.log(current);
            }
            count++;
            current = current.next;
        }

        return null;
    }
    // Remove at index

    removeAt(index){
        let current = this.head;
        let previous;
        let count = 0;

        if(index > this.size && count > index){
            return;
        }
        else{
            while(count < index){
                previous = current; // Node before index
                count++;
                current = current.next; // Node after index
            }
            if(previous.next){
                previous.next = current.next; 
                current.next.prev = previous.next;
            } else{
                console.log(`Node with index: ${index} doesn't exist`)
            }
        }

        this.size--;
    }

    // Clear list
    clearList(){
        this.head = null;
        this.size = 0;
    }
    // Print list data

    printListData(){
        let current = this.head;

        while(current){
            console.log(current.data);
            current = current.next;
        }
    }

    printList(){
        let current = this.head;

        while(current){
            console.log(current);
            current = current.next;
        }
    }
}

let l = new DoublyLinkedList();
l.insertFirst(10);
l.insertLast(20);
l.insertFirst(30);
l.insertFirst(304214);
l.insertFirst(3052165216521);
l.insertFirst(5352531);
l.insertAt(500,2);
ll.insertAt(69,6)
l.bubblesort();
