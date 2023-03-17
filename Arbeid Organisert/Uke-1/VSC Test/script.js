function noLayout() {
    document.getElementById('cards').classList.value = ('');
}

function horizontalLayout() {
    noLayout();
    document.getElementById('cards').classList.add('horizontal');
}

function verticalLayout() {
    noLayout();
    document.getElementById('cards').classList.add('vertical')
}

function gridLayout() {
    noLayout();
    document.getElementById('cards').classList.add('grid');
}


function show1() {
    blankAll();
    document.getElementById('popUp1').innerHTML = /*html*/`
        <div class="innerCard">
        De to viktigste verktøyene vi skal bruke er disse:
            <ul>
                <li>
                    Koderedigeringsprogrammet <a href="https://code.visualstudio.com/">Visual Studio Code</a>
                    <br />Vi skal bruke noen <i>extensions</i>:
                    <ul>
                        <li>JavaScript-booster</li>
                        <li>es6-string-html</li>
                        <li>live-server</li>
                        <li>live-share</li>
                    </ul>
                </li>
                <li>Nettleseren <a href="https://www.google.com/intl/no/chrome/">Google Chrome</a></li>
            </ul>        
        </div>
    `;
}

function show2() {
    blankAll();
    document.getElementById('popUp2').innerHTML =/*html*/` 
        <div class="innerCard">
        Vi bruker HTML til å definere et dokument
            <ul>
                <li>Tagger for grunnleggende oppsett av en HTML-fil</li>
                <li>Tagger for grunnleggende formatering av tekst</li>
                <li><tt>&lt;div&gt;</tt></li>
                <li><tt>&lt;input type="text"&gt;</tt> </li>
                <li><tt>&lt;button&gt;</tt></li>
                <li><a href="https://www.w3schools.com/html/default.asp" target="_new"> W3Schools HTML Tutorial</a></li>
                <li><a href="https://www.w3schools.com/tags/default.asp" target="_new"> W3Schools HTML Reference</a></li>
            </ul>
        </div>
    `;
}

function show3() {
    blankAll();
    document.getElementById('popUp3').innerHTML = /*html*/`
    <div class="innerCard">
    Vi bruker CSS til å <tt>style</tt> et dokument, altså farger, fonter, utseende og lignende.
    <ul>
        <li><tt>background-color</tt></li>
        <li><tt>color</tt></li>
        <li><tt>padding</tt></li>
        <li><tt>margin</tt></li>
        <li><tt>border</tt></li>
        <li><tt>text-align</tt></li>
        <li><tt>font-size</tt></li>
        <li> <a href="https://css-tricks.com/snippets/css/a-guide-to-flexbox/" target="_new"> Flexbox </a>
        </li>
        <li> <a href="https://css-tricks.com/snippets/css/complete-guide-grid/" target="_new"> Grid </a>
        </li>
        <li> <a href="https://www.w3schools.com/css/default.asp" target="_new"> W3Schools CSS Tutorial </a>
        </li>
        <li> <a href="https://www.w3schools.com/cssref/default.asp" target="_new"> W3Schools CSS Reference
            </a>
        </li>
    </ul>
</div>
    `;
}

function show4() {
    blankAll();
    document.getElementById('popUp4').innerHTML = /*html*/`
    <div class="innerCard">
    Det viktigste vi skal lære er programmeringsspråket JavaScript. Vi skal lære grunnleggende programmering
    ved
    å
    manipulere HTML- og CSS-kode på en nettside ved hjelp av JavaScript.
    <ul>
        <li>Det finnes en W3Schools JavaScript Tutorial, men her anbefaler vi heller å følge kurset vårt på
            Moodle.
        </li>
        <li> <a href="https://www.w3schools.com/jsref/default.asp" target="_new"> W3Schools JavaScript
                Reference
            </a></li>
    </ul>
</div>
    `;
}

function show5() {
    blankAll();
    document.getElementById('popUp5').innerHTML = /*html*/`
    <div id="head" class="bodyPart"></div>
    <div id="body" class="bodyPart"></div>
    <div id="legs" class="bodyPart"></div>
    `;
    buttonHead1();
    buttonBody1();
    buttonLegs1();
}

function buttonHead1() {
    document.getElementById('head').innerHTML = /*html*/`
    <div id="head" class="bodyPart">
<button onclick="buttonHead4()">◀</button>
<img src="img/head1.png" />
<button onclick="buttonHead2()">▶</button>
</div>
`;
}

function buttonHead2() {
    document.getElementById('head').innerHTML = /*html*/`
    <div id="head" class="bodyPart">
<button onclick="buttonHead1()">◀</button>
<img src="img/head2.png" />
<button onclick="buttonHead3()">▶</button>
</div>
`;
}

function buttonHead3() {
    document.getElementById('head').innerHTML = /*html*/`
<button onclick="buttonHead2()">◀</button>
<img src="img/head3.png" />
<button onclick="buttonHead4()">▶</button>
`;
}

function buttonHead4() {
    document.getElementById('head').innerHTML = /*html*/`
    <div id="head" class="bodyPart">
<button onclick="buttonHead3()">◀</button>
<img src="img/head4.png" />
<button onclick="buttonHead1()">▶</button>
</div>
`;
}

function buttonBody1() {
    document.getElementById('body').innerHTML = /*html*/`
<button onclick="buttonBody4()">◀</button>
<img src="img/body1.png" />
<button onclick="buttonBody2()">▶</button>
`;
}

function buttonBody2() {
    document.getElementById('body').innerHTML = /*html*/`
<button onclick="buttonBody1()">◀</button>
<img src="img/body2.png" />
<button onclick="buttonBody3()">▶</button>
`;
}

function buttonBody3() {
    document.getElementById('body').innerHTML = /*html*/`
<button onclick="buttonBody2()">◀</button>
<img src="img/body3.png" />
<button onclick="buttonBody4()">▶</button>
`;
}

function buttonBody4() {
    document.getElementById('body').innerHTML = /*html*/`
<button onclick="buttonBody3()">◀</button>
<img src="img/body4.png" />
<button onclick="buttonBody1()">▶</button>
`;
}

function buttonLegs1() {
    document.getElementById('legs').innerHTML = /*html*/`
<button onclick="buttonLegs4()">◀</button>
<img src="img/legs1.png" />
<button onclick="buttonLegs2()">▶</button>
`;
}

function buttonLegs2() {
    document.getElementById('legs').innerHTML = /*html*/`
<button onclick="buttonLegs1()">◀</button>
<img src="img/legs2.png" />
<button onclick="buttonLegs3()">▶</button>
`;
}

function buttonLegs3() {
    document.getElementById('legs').innerHTML = /*html*/`
<button onclick="buttonLegs2()">◀</button>
<img src="img/legs3.png" />
<button onclick="buttonLegs4()">▶</button>
`;
}

function buttonLegs4() {
    document.getElementById('legs').innerHTML = /*html*/`
<button onclick="buttonLegs3()">◀</button>
<img src="img/legs4.png" />
<button onclick="buttonLegs1()">▶</button>
`;
}

function blankAll() {
    document.getElementById('popUp1').innerHTML = '';
    document.getElementById('popUp2').innerHTML = '';
    document.getElementById('popUp3').innerHTML = '';
    document.getElementById('popUp4').innerHTML = '';
    document.getElementById('popUp5').innerHTML = '';
}
