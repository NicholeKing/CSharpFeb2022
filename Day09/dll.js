// Doubly Linked List

// Node class
class DNode{
    constructor(val){
        this.value = val;
        this.next = null;
        // This is what makes a doubly linked list
        this.prev = null;
    }
}

// DLL class
class DLL{
    // When a dll is first established it has no values but it does have a head and tail that start at null
    constructor(){
        // Front of the list
        this.head = null;
        // Back of the list
        this.tail = null;
    }
    // Function that adds nodes
    // Add to the front of the DLL
    addToFront(val){
        // Step one: make a new node
        let newNode = new DNode(val);
        // What do we have to consider when adding to the front of a linked list?
        // Question 1: is there an already assigned head node?
        // Answer: no, there is no node at head
        // If this.head == null we need to set our new value into the head
        if(!this.head){
            this.head = newNode;
            this.tail = newNode;
        } else {
            // Answer: yes, there is a node at head
            newNode.next = this.head;
            this.head.prev = newNode;
            this.head = newNode;
        }
    }
    // Add to the back of the DLL
    addToBack(val){
        // Step one: make a new node
        let newNode = new DNode(val);
        // Step two: we need to check if a head or tail exist
        if(!this.head){
            this.head = newNode;
            this.tail = newNode;
        } else {
            // If there IS a tail
            this.tail.next = newNode;
            newNode.prev = this.tail;
            this.tail = newNode;
        }
    }
    // Remove from the front
    removeFromFront(){
        // Things to think about:
        // Is there even anything to remove?
        if(!this.head){
            return false;
        }
        // What if there is only one value?
        // If there's only one value you can't do head.next, because there is no .next
        // The value to remove is ALSO our tail
        if(this.head === this.tail){
            this.head = null;
            this.tail = null;
            return true;
        }
        // head's next needs to become the new head
        // Option 3: there is more than one value
        this.head = this.head.next;
        this.head.prev = null;
    }
    // Remove from the back
    removeFromBack(){
        // First thing: check if it's empty
        if(!this.head){
            return false;
        }
        // Check if there is only one value
        if(this.head === this.tail){
            this.head = null;
            this.tail = null;
            return true;
        }
        // Final option: there is more than one value
        this.tail = this.tail.prev;
        this.tail.next = null;
    }

    display(){
        // Edge case: nothing in the list
        if(this.head == null){
            console.log("Nothing to print");
        } else {
            var runner = this.head;
            var result = "<-";
            while(runner){
                result += `${runner.value} <-> `;
                runner = runner.next;
            }
            console.log(result);
        }
    }
}

let newList = new DLL();
newList.addToFront(7);
newList.addToBack(9);
newList.addToBack(2);
newList.addToBack(10);
newList.addToBack(8);
newList.addToBack(5);
newList.addToBack(12);
// newList.removeFromFront();
// console.log(newList.head);
// console.log(newList.tail);
newList.display();