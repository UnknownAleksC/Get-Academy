
var chngSecEd = document.getElementById('chngSecID');
var chngMinEd = document.getElementById('chngMinID');
let isPaused = true;
var secToShow = 0;
var minToShow = 0;

var secTime = setInterval(chngSec, 1000);



function pauseAlter() {
    isPaused = true;
}
function startAlter() {
    isPaused = false;
}

function chngSec() {
    if (!isPaused) {
        secToShow++;
        chngSecEd.innerHTML = secToShow;

        if (secToShow == 60) {
            setTimeout(chngMin, 0);
            secToShow = 0;
            chngSecEd.innerHTML = secToShow;
        }
    }
}

function chngMin() {
    minToShow++;
    chngMinEd.innerHTML = minToShow;

    if (minToShow == 60) {
        minToShow = 0;
        chngMinEd.innerHTML = minToShow;
    }
}

function resetNum() {
    isPaused = true;
    chngSecEd.innerHTML = 0;
    secToShow = 0;
    chngMinEd.innerHTML = 0;
    minToShow = 0;
}