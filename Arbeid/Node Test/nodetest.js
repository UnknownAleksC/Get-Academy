class Node {
    constructor(data, next = null) {
        this.data = data
        this.next = next
    }
}

class LinkedList {
    constructor() {
        this.head = null; // Sets head to null because it doesn't exist
        this.size = 0; // Default size for the linked list
    }

    // Insert First Node
    insertFirst(data) {
        this.head = new Node(data, this.head);
        this.size++;
    }

    // Insert Last Node
    insertLast(data) {
        let node = new Node(data);
        let current;

        // If empty, make head
        if (!this.head) this.head = node;
        // If not empty, make new node
        else {
            current = this.head;

            while (current.next) {
                current = current.next;
            }

            current.next = node;
        }

        this.size++;
    }

    // Insert at Index
    insertAt(data, index) {
        // If index is out of range
        if (index > 0 && index > this.size) return;

        // If first index
        if (index === 0) {
            // this.head = new Node(data, this.head);
            this.insertFirst(data);
            return;
        }

        const node = new Node(data);
        let current, previous;

        // Set current to first
        current = this.head;
        let count = 0;

        while (count < index) {
            previous = current; // Node before index
            count++;
            current = current.next; // Node after index
        }

        node.next = current;
        previous.next = node;

        this.size++;
    }

    // Get at Index
    getAt(index) {
        let current = this.head;
        let count = 0;

        while (current) {
            if (count == index) {
                console.log(current.data)
            }
            count++;
            current = current.next;
        }

        return null;
    }

    // Remove at Index
    removeAt(index) {
        if (index > 0 && index > this.size) return;

        let current = this.head;
        let previous;
        let count = 0;

        // Remove first
        if (index === 0) this.head = current.next;
        // Remove at index
        else {
            while (count < index) {
                count++;
                previous = current;
                current = current.next;
            }

            previous.next = current.next;
        }

        this.size--;
    }

    // Clear list
    clearList() {
        this.head = null;
        this.size = 0;
    }

    // Print list data
    printListData() {
        let current = this.head;

        while (current) {
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
ll.insertAt(500, 2); // Inserts at index
ll.insertAt(600, 0); // Inserts at first index
ll.insertAt(600, 99); // Inserts at invalid index

// ll.getAt(5);
// ll.removeAt(99)

// ll.clearList();

// console.log(ll);
// ll.printListData();

// let numbers = [3, 7, 11]