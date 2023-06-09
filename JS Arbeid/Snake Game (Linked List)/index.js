let snakeModel;
let intervalId;
initModel();

function controlSnake(e) {
    if (e.keyCode == 37) {  //left
        snakeModel.direction = { x: -1, y: 0 };
    }
    else if (e.keyCode == 39) { //right
        snakeModel.direction = { x: 1, y: 0 };
    }
    else if (e.keyCode == 38) {  //up
        snakeModel.direction = { x: 0, y: -1 };
    }
    else if (e.keyCode == 40) {  //down
        snakeModel.direction = { x: 0, y: 1 };
        // snakeModel.food = createRandomPosition();
        snakeModel.growCount = 1;
    }
}

function createNewSnakeHead() {
    return {
        x: snakeModel.snakeHead.x + snakeModel.direction.x,
        y: snakeModel.snakeHead.y + snakeModel.direction.y,
        nextBodyPart: snakeModel.snakeHead,
    }
}

function createRandomPosition() {
    return {
        x: Math.floor(Math.random() * snakeModel.size),
        y: Math.floor(Math.random() * snakeModel.size)
    };
}

function initModel() {
    snakeModel = { size: 5000 };
    snakeModel.snakeHead = createRandomPosition();
    // snakeModel.food = createRandomPosition();
    snakeModel.growCount = 0;
    snakeModel.nextBodyPart = null;
    intervalId = setInterval(move, 1000);
}

function move() {
    if (!snakeModel.direction) return;
    snakeModel.snakeHead = createNewSnakeHead();
    console.log(snakeModel);
    if (snakeModel.growCount > 0) {
        snakeModel.growCount--;
    } else {
        //Slette siste element
        let bodyPart = snakeModel.snakeHead;
        let lastBodyPart = null;
        while (bodyPart.nextBodyPart != null) {
            lastBodyPart = bodyPart;
            bodyPart = bodyPart.nextBodyPart;
        }
        if (lastBodyPart !== null) {
            lastBodyPart.nextBodyPart = null;
        }
    }
}