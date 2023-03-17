// Variabler 1
var outputDiv = document.getElementById('output');
var numToShow = 0; {
    function setNum16() {
        numToShow = 16;
        outputDiv.innerHTML = numToShow;
    }

    function setNum47() {
        numToShow = 47;
        outputDiv.innerHTML = numToShow;
    }

    // Variabler 2
    function setNum(selectNum) {
        numToShow = selectNum;
        outputDiv.innerHTML = numToShow;
    }

    function incNum() {
        numToShow++;
        outputDiv.innerHTML = numToShow;
    }

    function incNum2() {
        numToShow = numToShow + 2;
        outputDiv.innerHTML = numToShow;
    }

    function incReset() {
        numToShow = 0;
        outputDiv.innerHTML = numToShow;
        colorChange.style.backgroundColor="white";
    }

    function decNum() {
        numToShow--;
        outputDiv.innerHTML = numToShow;
    }

    function decNum2() {
        numToShow = numToShow - 2;
        outputDiv.innerHTML = numToShow;
    }
}

// Variable Oppgave

var colorChange = document.getElementById('body');

function setBackColor(backColor){
    colorChange.style.backgroundColor=(backColor);
    console.log(backColor)
}