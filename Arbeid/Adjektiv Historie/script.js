const adjStory = document.getElementById('adjHistory');
const wrdChck1 = document.getElementById('word1');
const wrdChck2 = document.getElementById('word2');
const wrdChck3 = document.getElementById('word3');
const wrdChck4 = document.getElementById('word4');
const wrdChck5 = document.getElementById('word5');


function storyTime() {
    adjStory.innerHTML = `<p>ADJEKTIV HISTORIE:<br/>Once upon a time, there was a ${wrdChck1.value} king that had a ${wrdChck2.value} son. One day the son found a ${wrdChck3.value} rock that had a ${wrdChck4.value} face. The ${wrdChck1.value} king was not happy with this and threw the ${wrdChck3.value} rock into the ${wrdChck5.value} river.</p>`
}

function updateText(theId, newVal) {
    document.getElementById(`${theId}`).value = newVal;
    storyTime();
}