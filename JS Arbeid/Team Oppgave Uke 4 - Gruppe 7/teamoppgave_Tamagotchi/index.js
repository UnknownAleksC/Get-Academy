// MODEL
let intervalId = 0;
let pointsEarned = 0;
let secondsPassed = 0;
let tamagotchiName = 'Sigward';
let buttonDisabled = '';
let activities = [100, 100, 100];
let html = '';
let tamagotchiFace = '';

// VIEW
// Enable og Disable navn givning
giveName();
function giveName() {
    html = `
    <input type="text" maxlength="16" size="16" value="" onchange="petNameChange(this)"/> 
    <div>Gi tamagotchien sitt eget navn!</div>
    `;
    document.getElementById('app').innerHTML = html;
}

// Enable og Disable uten navn givning
// updateView();
function updateView() {
    limitBreakGuard();
    tamagotchiAppearance();
    html = /*HTML*/ `
    <h1 class='headline'>🦉Tamagotchi🦉</h1>
    
    <div>
        <div><h3>Du har overlevd ${secondsPassed} sekunder</h3></div> <br>
        <div><h3>POENGSUM: ${pointsEarned.toFixed(1)}</h3></div>
    </div>

    <hr>

    <div class='tamagotchiDiv'>
            <div class='tamagotchiBall'></div>
        <img src='images/${tamagotchiFace}.png'>
    </div>

    <hr>
    
    
    <div class='status-div'>
        <button class='buttonTest' buttonDisabled onclick='getPointForClick(0)'>🚾</button> 
        <div class="status-bar">${activities[0]}%</div> <br>
        
        <button class='buttonTest littTilHøyre' buttonDisabled onclick='getPointForClick(1)'>🍕</button>
        <div class="status-bar">${activities[1]}%</div> <br>
    
        <button class='buttonTest' buttonDisabled onclick='getPointForClick(2)'>💤</button>
        <div class="status-bar">${activities[2]}%</div> <br>

        <button class='resetButton' onclick=reset()>Nytt spill</button>
    </div>

    <hr>
    
    <div>${tamagotchiName} elsker deg!</div>


    `;
    document.getElementById('app').innerHTML = html;

    // Hvis intervalId ikke har en verdi, blir den gitt setInterval som starter perSecond funksjonen hvert sekund
    if (intervalId === 0) {
        intervalId = setInterval(perSecond, 1000);
    }

    // Her blir det sjekket om en av aktivitetene har nådd 0%, 
    // hvis dette er korrekt blir intervalIden satt til 1 som stopper perSecond funksjonen
    if (activities[0] === 0 || activities[1] === 0 || activities[2] === 0) {
        clearInterval(intervalId);
        intervalId = 1;
    }
}

// CONTROLLER 
// Hvert sekund blir det lagt på et sekund på timeren og et poeng til poengsummen
function perSecond() {
    pointsEarned++;
    secondsPassed++;

    activities[0] -= 5;
    activities[1] -= 5;
    activities[2] -= 5;

    updateView();
}

// Passer på at ingen av aktivtetene går over 100%
function limitBreakGuard() {
    // if (activities[0] > 100) {
    //     activities[0] = 100;
    // }
    // if (activities[1] > 100) {
    //     activities[1] = 100;
    // }
    // if (activities[2] > 100) {
    //     activities[2] = 100;
    // }

    activities[0] = activities[0] > 100 ? activities[0] = 100 : activities[0];
    activities[1] = activities[1] > 100 ? activities[1] = 100 : activities[1];
    activities[2] = activities[2] > 100 ? activities[2] = 100 : activities[2];
}

// Gir poeng og høyere prosent i aktivitets baren for å ha klikket en av aktivitets knappene
function getPointForClick(number) {
    if (activities[0] === 0 || activities[1] === 0 || activities[2] === 0) {
        clearInterval(intervalId);
        intervalId = 1;
        buttonDisabled = 'disabled';
    }
    else {
        pointsEarned += 0.1;
        activities[number] += 5;
    }
    updateView();
}

// Utseende til tamagotchien blir valgt basert på hvor mange prosent som står på aktivitets barene
function tamagotchiAppearance() {
    if (activities[0] && activities[1] && activities[2] > 75) {
        tamagotchiFace = 'Tamagotchi_Happy';
    }
    else if (activities[0] && activities[1] && activities[2] > 25) {
        tamagotchiFace = 'Tamagotchi_Neutral';
    }
    else if (activities[0] && activities[1] && activities[2] > 0) {
        tamagotchiFace = 'Tamagotchi_Sad';
    }
    else {
        tamagotchiFace = 'Tamagotchi_Dead';
    }
}

// Gir navn til tamagotchien
function petNameChange(thisParameter) {
    tamagotchiName = thisParameter.value;
    updateView();
}

// Reset tamagotchi
function reset() {
    location.reload();
}