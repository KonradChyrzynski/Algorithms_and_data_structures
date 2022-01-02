class Node {
    constructor(data, next = null){
        this.data = data;
        this.next = next;
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

    clearList(){
        this.head = null;
        this.size = 0;
    }

    printListData(){
        let current = this.head;

        while(current){
            console.log(current.data);
            current = current.next;
        }
    }

    atIndex(index){
        let current = this.head;
        let previous;
        let count = 0;
        if(index > this.size){return console.log(`There is nothink at index ${index}`)}

        else{
            while(count < index ){
                previous = current;
                current = current.next;
                count++
            }

            console.log(current.data);
        }
    }

    // findIndexPromise(data){

    //     return new Promise((resolve,reject) => {
    //         let current = this.head;
    //         let count = 0;
    //         while(current.data !== data ){
    //             current = current.next;
    //             if(current == null){
    //                 reject();
    //             }
    //             count++

    //         }
    //         resolve(count);
    //     })
        
    // }

    findIndex(data){
        let current = this.head;
        let count = 0;
        while(current){
            count++;
            if(current.data == data){return console.log(count)}
            current = current.next;
        }
        return console.log(`${data} does not exist in this list`)
    }

}

const ll = new LinkedList();

ll.insertFirst(100);
ll.insertFirst(200);
ll.insertFirst(300); 
ll.insertLast(400);
ll.insertAt(500, 0);
ll.printListData();
ll.atIndex(2)
// ll.findIndexPromise(2000).then((a) => console.log(a)).catch((e) => console.log("Property does not exist in this list"));