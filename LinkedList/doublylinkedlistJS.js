class Node {
    constructor(data, next = null,){
        this.data = data;
        this.next = next;
        this.prev
    }
}



class LinkedList {
    constructor(){
        this.head = null;
        this.size = 0;
    }

    // Insert first node
    insertFirst(data){
        this.head = new Node(data, this.head);
        if(this.head.next){
            this.head.next.prev = this.head;
        }
        this.size++;
    }
    // Insert last node
    insertLast(data){
        let node = new Node(data);
        let current;
        
        if(!this.head){
            this.head = node;
        } else {
            current = this.head;
            while(current.next){
                current = current.next;
            }

            current.next = node;
            current.next.prev = current;
        }

        this.size++;
    }

    // Insert at index

    insertAt(data, index){
        // If index is out of range
        if(index > 0 && index > this.size){
            return;
        }


        if(index === 0 ){
            this.insertFirst(data);
            return;
        }

        const node = new Node(data);

        let current, previous;
        current = this.head;

        let count = 0;

        while(count < index){
            previous = current; // Node before index
            count++;
            current = current.next; // Node after index
        }

        node.next = current;
        node.prev = previous;
        if(current){
            current.prev = node;
        }
        previous.next = node;

        this.size++;
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

const ll = new LinkedList();

ll.insertFirst(100);   // 2
ll.insertFirst(300);  // 1
ll.insertFirst(400); // 0
ll.removeAt(1);
ll.clearList();
ll.printList();