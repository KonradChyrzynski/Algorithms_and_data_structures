class Node {
    constructor(data, next = null){
        this.data = data;
        this.next = next;
        this.prev;
    }
}



class LinkedList {
    constructor(){
        this.head = null;
        this.tail = null;
        this.size = 0;
    }

    // Insert first node
    insertFirst(data){
        this.head = new Node(data, this.head);
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
        previous.next = node;

        this.size++;
    }

    // Get at index
    getAt(index){
        let current = this.head;

        let count = 0;

        while(current){
            if(count == index){
                console.log(current.data);
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

        if(index > count && index > this.size){
            return
        }else{
            while(index < count){
                count++;
                previous = current;
                current = current.next;
            }

            previous.next = current.next;
            
            
        }

        this.size--;
    }

    // Clear list
    clearList(){
        let current = this.head;
        while(current != null){
            
        }
    }
    // Print list data

    printListData(){
        let current = this.head;

        while(current){
            console.log(current.data);
            current = current.next;
        }
    }

}

const ll = new LinkedList();

ll.insertFirst(100);
ll.insertFirst(200);
ll.insertFirst(300); 
ll.insertLast(400);
ll.insertAt(500, 0);
ll.printListData();
ll.getAt(1)
ll.clearList()