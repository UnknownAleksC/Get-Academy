snake = {
    cords: { x: 10, y: 10 },
    bodySize: 0,
};


function snakeHead() {
    this.oldData = this.newData;
    this.newData = snake.cords;
    this.next = insertBody(this.oldData)
}

function snakeBody(data, next = null) {
    this.oldData = this.newData;
    this.newData = data;
    this.next = next
}

function insertBody(newData) {
    let body = new snakeBody(newData, this.head);
    let current;
    let count = 0;

    if (!this.head) this.head = body;
    else (
        current = this.head;
    while (count < bodySize) {

    }
    )
}

console.log(new snakeHead);