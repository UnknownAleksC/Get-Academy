var order = [];

function hideElement() {
    let inv = document.getElementById("divToHide");
    if (inv.style.display === "none") {
        inv.style.display = "block";
    } else {
        inv.style.display = "none";
    }
}

function imageDoClick(imageInfo, imgNum) {
    if (order.length < 9) {
            var imageClicked = document.createElement("img");
            imageClicked.setAttribute('src', `images/pinkOwlPiece${imgNum}.png`);
            imageClicked.setAttribute('class', 'gridInsideBox2')
            document.getElementById('inventoryUnsorted').appendChild(imageClicked);
            order.push(imgNum)
            isOrderRight()
    };
}

function isOrderRight() {
    if (order[0] === 1 &&
        order[1] === 2 &&
        order[2] === 3 &&
        order[3] === 4 &&
        order[4] === 5 &&
        order[5] === 6 &&
        order[6] === 7 &&
        order[7] === 8 &&
        order[8] === 9) {
        victory();
    }
}

function victory() {
    victoryBird = document.getElementById("ugleIRamme");
    victoryBird.style.display = "block";
}