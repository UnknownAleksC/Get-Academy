// MODEL
let numbers = [0, 0];
let playerInput = '';
let playerGuess = `Type in your answer and see the result!`;
let points = 0;

// VIEW
viewUpdate();
function viewUpdate() {
    document.getElementById('content').innerHTML = /*HTML*/ `
    <h2>Krokodille spillet!</h1>
    <div>Gjett om det første tallet er mindre (<), større (>) eller like stort (=) det andre tallet!</div>
    <input type="text" value="" onchange="crocodileGame(this)"> <br>
    <div> ${playerGuess} </div>
    `;
}

// CONTROLLER
function crocodileGame(checkThis) {
    playerInput = checkThis.value
    for (let i = 0; i < numbers.length; i++) {
        numbers[i] = Math.round(Math.random() * 10);
        console.log(numbers[i]);
    }
    if (numbers[0] < numbers[1]) {
        points = playerInput === ('<' || 'mindre' || 'smaller') ? points += 1 : points -= 1;
        playerGuess = playerInput === ('<' || 'mindre' || 'smaller') ? playerGuess = `Du gjettet riktig :) Du har nå ${points} poeng` : `Du gjettet feil :( Du har nå ${points} poeng`;
    }
    else if (numbers[0] > numbers[1]) {
        points = playerInput === ('>' || 'større' || 'bigger') ? points += 1 : points -= 1;
        playerGuess = playerInput === ('>' || 'større' || 'bigger') ? playerGuess = `Du gjettet riktig :) Du har nå ${points} poeng` : `Du gjettet feil :( Du har nå ${points} poeng`;
    }
    else if (numbers[0] === numbers[1]) {
        points = playerInput === ('=' || 'like stor' || 'same size') ? points += 1 : points -= 1;
        playerGuess = playerInput === ('=' || 'like stor' || 'same size') ? playerGuess = `Du gjettet riktig :) Du har nå ${points} poeng` : `Du gjettet feil :( Du har nå ${points} poeng`;
    }
    viewUpdate();
}