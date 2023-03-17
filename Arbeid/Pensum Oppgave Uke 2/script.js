const allPics = document.getElementById('picReset');
const showNameSelect = document.getElementById('showName');

function selectPic(element, idSelect, name) {
    element.innerHTML = `<img src="img/pic${idSelect}.png" class="picSelect" name="${name} onclick="selectPic(this, ${idSelect},'${name} ')">`;
    showNameSelect.innerHTML = `${name}`;
}

// function selectName(name) {
//     return element.name = name;
// }