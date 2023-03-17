function noBody() {
    document.getElementById('leBody').classList.value = ('');
}

function leBody1() {
    noBody();
    document.getElementById('leBody').classList.add('leBodyOP');
}

function leBody2() {
    noBody();
    document.getElementById('leBody').classList.add('zeBodyOP');
}

function heaven() {
    leBody1();
    document.getElementById('sky').innerHTML =/*html*/`
    <marquee direction="right" , behavior="alternate">
    <h1 id="tittel" style="font-size:50px; color: #e6ffff; text-decoration-line: underline;">VELKOMMEN</h1>
</marquee>
<div class="text"><img src="media/meg.png" width="380" height="500"> </div>
<div class="info">
    <pre class="text">
    <b>NAVN: Aleksander Carlsen</b>
    <b>ALDER: 22</b>
    <b>STATUS: LEVER</b>
    <b>HOBBY: Spill, bøker og redigering</b>
    </pre>
</div>
`;
}

function earth() {
    leBody2();
    document.getElementById('sky').innerHTML =/*html*/`
    <marquee direction="right" , behavior="alternate">
    <h1 id="tittel" style="font-size:50px; color: #a82037; text-decoration-line: underline;">✞︎☜︎☹︎😐︎⚐︎💣︎💣︎☜︎☠︎</h1>
</marquee>
<div class="text2"><img src="media/unknown.png" width="380" height="500"> </div>
<div class="info">
    <pre class="text2">
    <b>NAVN: ✌︎☹︎☜︎😐︎💧︎✌︎☠︎👎︎☜︎☼︎ 👍︎✌︎☼︎☹︎💧︎☜︎☠︎</b>
    <b>ALDER: 📄︎📄︎</b>
    <b>STATUS: ☹︎☜︎✞︎☜︎☼︎</b>
    <b>HOBBY: 💧︎◻︎♓︎●︎●︎📪︎ ♌︎⬂︎🙵♏︎❒︎ □︎♑︎ ❒︎♏︎♎︎♓︎♑︎♏︎❒︎♓︎■︎♑︎</b>
    </pre>
</div>
`;
}
