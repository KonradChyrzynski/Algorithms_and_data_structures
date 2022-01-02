class Node{
    constructor(data,next = null,previous = null){
        this.data = data;
        this.next = next;
        this.previous = previous;
    }
}

class doublyLinkedList {
    constructor(){
        this.head = null;
        this.tail = null;
        this.size = 0;
    }
    insertFirst(data){
        let node = this.head = new Node(data, this.head);
        if(this.size == 0){this.tail == null}
        this.size++;
    }

    insertLast(data){
        let current = this.head;

        while(current.next){current = current.next;}

        current.next = new Node(data,null,current);

        this.tail = current.next;

        this.size++;
        
    }

    insertAt(data,index){
        let count = 0;
        let current = this.head;
        let previous;
        while(count < index){
            previous = current;
            current = current.next;
            count++
        }
        let node = new Node(data,current,previous);
        previous.next = node;

        if(index == this.size){
            this.tail = node;
        }
        this.size++
        
    }

    deleteFirst(){
        if(this.size == 1){this.tail == null}
        let current = this.head;
        this.head = current.next;
        this.head.previous = null;
        this.size--;
    }

    deleteLast(){
        let current = this.head;
        let previous
        while(current.next){
            previous = current;
            current = current.next;
        } 

        previous.next == null;

    }

    deleteAt(index){
        let count = 0;
        let current = this.head;
        let previous;
        while(count < index){
            previous = current;
            current = current.next;
            count++;
        }
        current.next.previous = previous;
        previous.next = current.next;
        

    }

    printList(){
        console.log(this.head)
    }
    printTail(){
        console.log(this.tail)
    }


}

const ll = new doublyLinkedList();
ll.insertFirst(200);
ll.insertLast(300);
ll.insertAt(500,2);
ll.deleteAt(1);
ll.printList();