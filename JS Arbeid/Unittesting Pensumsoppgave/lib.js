// const mainDiv = document.getElementById('app');
// let testNavn = 'Terje';
// mainDiv.innerHTML = /* HTML */ `<input type="text" id="nameValue" value="Terje" oninput="${testNavn = this.value}"/>`
// console.log(testNavn);

function returnAge(inputYear) {
    return new Date().getFullYear() - inputYear;
}

function returnName(testNavn) {
    return testNavn;
}